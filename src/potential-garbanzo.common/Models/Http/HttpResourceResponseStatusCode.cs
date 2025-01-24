﻿// Copyright (c) Andrew Butson.
// Licensed under the MIT License.

using System.ComponentModel;
using ApiStudioIO.Utility.Extensions;

namespace ApiStudioIO.Common.Models.Http
{
    public class HttpResourceResponseStatusCode : IHttpResource
    {
        [Category("Hiddend")]
        [Browsable(false)]
        public string Name => $@"({HttpStatus}) {Description}";

        [Category("Definition")] public int HttpStatus { get; set; } = 200;

        [Category("RFC 7231")] public string Type => $"{HttpResponseExtension.GetHttpResponseCodeCategory(HttpStatus)}";

        [Category("RFC 7231")]
        public string Description => $"{HttpResponseExtension.GetHttpResponseCodeDescription(HttpStatus)}";

        [Category("ApiStudio Metadata")]
        [Browsable(false)]
        public bool IsAutoGenerated { get; set; } = false;
    }
}