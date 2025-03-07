﻿// Copyright (c) Andrew Butson.
// Licensed under the MIT License.

using System.Collections.Generic;
using ApiStudioIO.Common.Models.Build;
using ApiStudioIO.Vs.Output;
using ApiStudioIO.CodeGen.Utility;

namespace ApiStudioIO.CodeGen.CSharpAzureFunctionDotNet6.Build
{
    internal static class SdkHttpAuthOAuth2
    {
        internal static List<SourceCodeEntity> Build(ApiStudio apiStudio, string modelName)
        {
            var sourceList = new List<SourceCodeEntity>();

            if (apiStudio.SecuritySchemeType != SecuritySchemeTypes.OAuth2 &&
                apiStudio.SecuritySchemeType != SecuritySchemeTypes.OpenIdConnect) return sourceList;

            var namespaceHelper = new NamespaceHelper(apiStudio, modelName);
            var sourceCode = Templates.AzureFunctionResource.HttpAuthOAuth2
                .Replace("{{TOKEN_OAS_NAMESPACE}}", namespaceHelper.Solution)
                .Replace("{{TOKEN_OAS_CLASS_NAME}}", modelName);
            sourceList.Add(new SourceCodeEntity($"{namespaceHelper.Solution}.OAuth2.cs", sourceCode, false));

            VsLogger.Log("[SdkHttpAuthOAuth2]: OAuth2/OpenIdConnect");

            return sourceList;
        }
    }
}