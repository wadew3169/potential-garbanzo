﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiStudioIO.CodeGen.CSharpAzureFunctionDotNet6.Templates {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AzureFunctionResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AzureFunctionResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ApiStudioIO.CodeGen.CSharpAzureFunctionDotNet6.Templates.AzureFunctionResource", typeof(AzureFunctionResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {{TOKEN_OAS_NAMESPACE}}
        ///{
        ///    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
        ///    using Microsoft.OpenApi.Models;
        ///    using System;
        ///
        ///    public partial class {{TOKEN_OAS_CLASS_NAME}}OpenApiOAuthSecurityFlows : OpenApiOAuthSecurityFlows
        ///    {
        ///        public {{TOKEN_OAS_CLASS_NAME}}OpenApiOAuthSecurityFlows()
        ///        {
        ///            Implicit = new OpenApiOAuthFlow()
        ///            {
        ///                AuthorizationUrl = new Uri(&quot;http://api-studio.io/oauth2/token&quot;),
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HttpAuthOAuth2 {
            get {
                return ResourceManager.GetString("HttpAuthOAuth2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {{TOKEN_OAS_NAMESPACE}}
        ///{
        ///    using System.Collections.Generic;
        ///
        ///    public partial class {{TOKEN_OAS_CLASS_NAME}}OpenApiOAuthSecurityFlows
        ///    {
        ///        private Dictionary&lt;string, string&gt; GetScopes()
        ///        {
        ///            var scopes = new Dictionary&lt;string, string&gt;();
        ///{{TOKEN_OAS_SCOPES}}
        ///            return scopes;
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string HttpAuthOAuth2Scopes {
            get {
                return ResourceManager.GetString("HttpAuthOAuth2Scopes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {{TOKEN_OAS_NAMESPACE}}
        ///{
        ///    using System.Net;
        ///    using System.Threading.Tasks;
        ///    using Microsoft.Azure.Functions.Worker;
        ///    using Microsoft.Azure.Functions.Worker.Http;
        ///    using Microsoft.Extensions.Logging;
        ///
        ///    public partial class {{TOKEN_OAS_CLASS_NAME}}
        ///    {
        ///        private readonly ILogger _logger;
        ///        public {{TOKEN_OAS_CLASS_NAME}}(ILoggerFactory loggerFactory)
        ///        {
        ///            _logger = loggerFactory.CreateLogger&lt;{{TOKEN_OAS_CLASS_NAME}}&gt;();
        ///        }
        ///
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HttpTrigger {
            get {
                return ResourceManager.GetString("HttpTrigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {{TOKEN_OAS_NAMESPACE}}
        ///{
        ///    using System;
        ///    using System.Collections.Generic;
        ///    using System.Net;
        ///    using System.Threading.Tasks;
        ///
        ///    using Microsoft.Azure.Functions.Worker;
        ///    using Microsoft.Azure.Functions.Worker.Http;
        ///    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
        ///    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
        ///    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
        ///    using Microsoft.OpenApi.Models;
        ///
        ///    using Mo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HttpTriggerDesigner {
            get {
                return ResourceManager.GetString("HttpTriggerDesigner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         private class {{TOKEN_OAS_HTTP_OPENAPI_HEADER_CLASS_NAME}} : IOpenApiCustomResponseHeader
        ///        {
        ///            public Dictionary&lt;string, OpenApiHeader&gt; Headers { get; set; } =
        ///                new Dictionary&lt;string, OpenApiHeader&gt;()
        ///                {
        ///{{TOKEN_OAS_HTTP_OPENAPI_HEADER_ITEMS}}
        ///                };
        ///        }.
        /// </summary>
        internal static string HttpTriggerDesignerResponseHeaderClass {
            get {
                return ResourceManager.GetString("HttpTriggerDesignerResponseHeaderClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to                     {
        ///                        &quot;{{TOKEN_OAS_HTTP_OPENAPI_HEADER_NAME}}&quot;,
        ///                        new OpenApiHeader()
        ///                        {
        ///                            Description = &quot;{{TOKEN_OAS_HTTP_OPENAPI_HEADER_DESCRIPTION}}&quot;,
        ///                            Schema = new OpenApiSchema() { Type = &quot;string&quot; },
        ///                            AllowEmptyValue = {{TOKEN_OAS_HTTP_OPENAPI_HEADER_ALLOWEMPTY}},
        ///                            Required = {{TOKEN_OAS_HTTP_OPENAPI_HEADER_REQUIRED}},
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HttpTriggerDesignerResponseHeaderItem {
            get {
                return ResourceManager.GetString("HttpTriggerDesignerResponseHeaderItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #nullable enable
        ///namespace {{TOKEN_OAS_NAMESPACE}}
        ///{
        ///    using System;
        ///    using System.Collections.Generic;
        ///    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
        ///
        ///    public class {{TOKEN_OAS_CLASS_NAME}}
        ///    {
        ///        [OpenApiProperty(Description = &quot;Example of required uuid&quot;, Default = &quot;5571596d-dd42-4fb6-8c20-2620cc43d432&quot;, Nullable = false)]
        ///        public Guid Identifier { get; set; } = new Guid(&quot;5571596d-dd42-4fb6-8c20-2620cc43d432&quot;);
        ///
        ///        [OpenApiProperty(Description = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Model {
            get {
                return ResourceManager.GetString("Model", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
        ///using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
        ///using Microsoft.OpenApi.Models;
        ///using System;
        ///
        ///namespace Configurations
        ///{
        ///    public class OpenApiConfigurationOptions : DefaultOpenApiConfigurationOptions
        ///    {
        ///        public override OpenApiInfo Info { get; set; } = new OpenApiInfo()
        ///        {
        ///            Version = @&quot;{{TOKEN_OAS_VERSION}}&quot;,
        ///            Title = @&quot;{{TOKEN_OAS_TITLE}}&quot;,
        ///            Description = @&quot;{ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OpenApiConfigurationOptions {
            get {
                return ResourceManager.GetString("OpenApiConfigurationOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be null or whitespace..
        /// </summary>
        internal static string SdkHttp_GenerateHttp___0___cannot_be_null_or_whitespace_ {
            get {
                return ResourceManager.GetString("SdkHttp_GenerateHttp___0___cannot_be_null_or_whitespace_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be null or whitespace..
        /// </summary>
        internal static string SdkHttpDesigner_GenerateHttp___0___cannot_be_null_or_whitespace_ {
            get {
                return ResourceManager.GetString("SdkHttpDesigner_GenerateHttp___0___cannot_be_null_or_whitespace_", resourceCulture);
            }
        }
    }
}
