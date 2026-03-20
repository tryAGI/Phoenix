
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ModelProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.ModelProvider ModelProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.TemplateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.Template Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptTemplateTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptTemplateType TemplateType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptTemplateFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptTemplateFormat TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.InvocationParametersJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.InvocationParameters InvocationParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::Phoenix.PromptTools? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Phoenix.ResponseFormatVariant1? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="modelProvider"></param>
        /// <param name="modelName"></param>
        /// <param name="template"></param>
        /// <param name="templateType"></param>
        /// <param name="templateFormat"></param>
        /// <param name="invocationParameters"></param>
        /// <param name="tools"></param>
        /// <param name="responseFormat"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersion(
            global::Phoenix.ModelProvider modelProvider,
            string modelName,
            global::Phoenix.Template template,
            global::Phoenix.PromptTemplateType templateType,
            global::Phoenix.PromptTemplateFormat templateFormat,
            global::Phoenix.InvocationParameters invocationParameters,
            string id,
            string? description,
            global::Phoenix.PromptTools? tools,
            global::Phoenix.ResponseFormatVariant1? responseFormat)
        {
            this.ModelProvider = modelProvider;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Template = template;
            this.TemplateType = templateType;
            this.TemplateFormat = templateFormat;
            this.InvocationParameters = invocationParameters;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description;
            this.Tools = tools;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        public PromptVersion()
        {
        }
    }
}