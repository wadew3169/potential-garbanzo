﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiStudioIO.CodeGen.CSharpMinimalApiDotNet6.Templates {
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
    internal class MinimalApiResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MinimalApiResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ApiStudioIO.CodeGen.CSharpMinimalApiDotNet6.Templates.MinimalApiResource", typeof(MinimalApiResource).Assembly);
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
        ///   Looks up a localized string similar to namespace {{TOKEN_OAS_PROJECTNAME}}.{{TOKEN_OAS_NAMESPACE}}
        ///{
        ///    //using Microsoft.Extensions.Logging;
        ///
        ///    public partial class {{TOKEN_OAS_CLASS_NAME}}
        ///    {
        ///        private readonly ILogger _logger;
        ///        private HttpContext _httpContext;
        ///
        ///        public {{TOKEN_OAS_CLASS_NAME}}(ILoggerFactory loggerFactory)
        ///        {
        ///            _logger = loggerFactory.CreateLogger&lt;{{TOKEN_OAS_CLASS_NAME}}&gt;();
        ///        }
        ///
        ///        public IResult RunAsync()
        ///        {
        ///            var headerCount = _httpCo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HttpEndpoint {
            get {
                return ResourceManager.GetString("HttpEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {{TOKEN_OAS_PROJECT_NAME}}.{{TOKEN_OAS_NAMESPACE}}
        ///{
        ///    using Swashbuckle.AspNetCore.Annotations;
        ///
        ///    public partial class {{TOKEN_OAS_CLASS_NAME}} : ICarterModule
        ///    {
        ///        public void AddRoutes(IEndpointRouteBuilder app)
        ///        {
        ///            app.Map{{TOKEN_OAS_HTTP_VERB}}(&quot;/{{TOKEN_OAS_HTTP_URI}}&quot;, async (HttpContext httpContext) =&gt;
        ///            {
        ///                _httpContext = httpContext;
        ///                return RunAsync();
        ///            })
        ///                .WithTags(&quot;{{TOKEN_OA [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HttpEndpointDesigner {
            get {
                return ResourceManager.GetString("HttpEndpointDesigner", resourceCulture);
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
        ///   Looks up a localized string similar to namespace Microsoft.Extensions.DependencyInjection;
        ///
        ///using Microsoft.OpenApi.Models;
        ///
        ///public static partial class ServiceCollectionExtensions
        ///{
        ///    public static WebApplicationBuilder AddSwagger(this WebApplicationBuilder builder)
        ///    {
        ///        builder.Services.AddSwagger();
        ///
        ///        return builder;
        ///    }
        ///
        ///    public static IServiceCollection AddSwagger(this IServiceCollection services)
        ///    {
        ///        services.AddEndpointsApiExplorer();
        ///        services.AddSwaggerGen(c =&gt;
        ///        {
        ///         [rest of string was truncated]&quot;;.
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
