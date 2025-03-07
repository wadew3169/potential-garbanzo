﻿// Copyright (c) Andrew Butson.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using ApiStudioIO.Common.Models.Build;
using ApiStudioIO.Common.Models.Http;
using ApiStudioIO.Utility.Extensions;
using ApiStudioIO.Vs.Output;
using ApiStudioIO.CodeGen.Utility;

namespace ApiStudioIO.CodeGen.CSharpMinimalApiDotNet6.Build
{
    internal static class SdkHttpEndpointDesigner
    {
        internal static List<SourceCodeEntity> Build(BuildTargetModel buildTargetModel, ApiStudio apiStudio, string modelName)
        {
            var sourceList = new List<SourceCodeEntity>();

            var namespaceHelper = new NamespaceHelper(apiStudio, modelName);
            apiStudio?.Resourced
                .SelectMany(resource => resource.HttpApis(),
                    (resource, httpApi) => new { resource, httpApi })
                .ToList()
                .ForEach(x => sourceList.Add(GenerateHttpTrigger(buildTargetModel, modelName, x.resource, x.httpApi, namespaceHelper)));

            return sourceList;
        }

        private static SourceCodeEntity GenerateHttpTrigger(BuildTargetModel buildTargetModel, string modelName, Resource resource, HttpApi httpApi,
            NamespaceHelper namespaceHelper)
        {
            if (string.IsNullOrWhiteSpace(modelName))
                throw new ArgumentException(
                    string.Format(
                        Templates.MinimalApiResource
                            .SdkHttpDesigner_GenerateHttp___0___cannot_be_null_or_whitespace_,
                        nameof(modelName)), nameof(modelName));
            _ = resource ?? throw new ArgumentNullException(nameof(resource));
            _ = httpApi ?? throw new ArgumentNullException(nameof(httpApi));

            var httpEndpointResponses = BuildHttpEndpointResponseStatusCodes(httpApi);
            var httpRequestParameter = BuildHttpEndpointRequestParameter(httpApi);

            var httpTriggerDesignerSourceCode = Templates.MinimalApiResource.HttpEndpointDesigner
                .Replace("{{TOKEN_OAS_PROJECT_NAME}}", buildTargetModel.ProjectName)
                .Replace("{{TOKEN_OAS_NAMESPACE}}", namespaceHelper.Solution)
                .Replace("{{TOKEN_OAS_CLASS_NAME}}", $"Http{httpApi.DisplayName.ToAlphaNumeric()}")
                .Replace("{{TOKEN_OAS_HTTP_VERB}}", httpApi.HttpVerb)
                .Replace("{{TOKEN_OAS_HTTP_URI}}", resource.HttpApiUri)
                .Replace("{{TOKEN_OAS_HTTP_TAG}}", $"{modelName}")
                .Replace("{{TOKEN_OAS_HTTP_NAME}}", $"{httpApi.DisplayName}")
                .Replace("{{TOKEN_OAS_DESCRIPTION}}", httpApi.Description)
                .Replace("{{TOKEN_OAS_HTTP_REQUEST_BODY_MEMBER}}", httpRequestParameter != null ? $"private {httpRequestParameter.DataType} _requestBody;" : "")
                .Replace("{{TOKEN_OAS_HTTP_REQUEST_BODY_PARAMETER}}", httpRequestParameter != null ? $", {httpRequestParameter.DataType} requestBody" : "")
                .Replace("{{TOKEN_OAS_HTTP_REQUEST_BODY_SET_MEMBER}}", httpRequestParameter != null ? "_requestBody = requestBody;" : "")
                .Replace("{{TOKEN_OAS_PRODUCES}}", string.Join(Environment.NewLine, httpEndpointResponses));

            VsLogger.Log($"[SdkHttpEndpointDesigner]: {namespaceHelper.Solution}-{httpApi.DisplayName}.HttpEndpoint.Designer");

            return new SourceCodeEntity($"{namespaceHelper.Solution}-{httpApi.DisplayName}.HttpEndpoint.Designer.cs",
                httpTriggerDesignerSourceCode, true, $"{modelName}-{httpApi.DisplayName}.HttpEndpoint.cs");
        }


        private static HttpResourceParameter BuildHttpEndpointRequestParameter(HttpApi httpApi)
        {
            return httpApi.RequestParameters.FirstOrDefault(parameter => parameter.FromType == HttpTypeParameterLocation.Body);
        }


        private static IEnumerable<string> BuildHttpEndpointResponseStatusCodes(HttpApi httpApi)
        {
            const string applicationJson = "\"application/json\"";
            var attributes = new List<string>();
            foreach (var statusCode in httpApi.ResponseStatusCodes)
            {
                var httpStatus = Enum.GetName(typeof(HttpStatusCodes), statusCode.HttpStatus);
                httpStatus = httpStatus != null
                    ? $"StatusCodes.{httpStatus}"
                    : $"{statusCode.HttpStatus}";

                if (httpApi.DataModels != null && statusCode.Type == "Success" && httpApi.DataModels.Count > 0)
                    attributes.Add(
                        $"\t\t\t\t.Produces<{httpApi.DataModels?[0].Name}>(statusCode: {httpStatus}, contentType: {applicationJson})");
                else if (httpApi.DataModels != null && statusCode.Type == "Success" && httpApi.DataModels.Count == 0)
                    attributes.Add(
                        $"\t\t\t\t.Produces(statusCode: {httpStatus}, contentType: {applicationJson})");
                else
                    attributes.Add(
                        $"\t\t\t\t.Produces<ErrorModel>(statusCode: {httpStatus}, contentType: {applicationJson})");
            }
            return attributes;
        }
    }
}