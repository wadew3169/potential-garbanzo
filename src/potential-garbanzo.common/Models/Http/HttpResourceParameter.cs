﻿// Copyright (c) Andrew Butson.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace ApiStudioIO.Common.Models.Http
{
    public class HttpResourceParameter : IHttpResource
    {
        [Category("Hiddend")]
        [Browsable(false)]
        public string Name =>
            $"{Identifier} ({DataType}) [{Enum.GetName(typeof(HttpTypeParameterLocation), FromType)}]";

        [Category("Definition")] public string Identifier { get; set; } = "ParameterName";

        [Category("Definition")] public string DataType { get; set; } = "string";

        [Category("Definition")]
        public string Description { get; set; } = "This is a description about the API parameter";

        [Category("Definition")] public bool IsRequired { get; set; } = false;

        [Category("Definition")]
        public HttpTypeParameterLocation FromType { get; set; } = HttpTypeParameterLocation.Query;

        [Category("ApiStudio Metadata")]
        [Browsable(false)]
        public bool IsAutoGenerated { get; set; } = false;
    }
}