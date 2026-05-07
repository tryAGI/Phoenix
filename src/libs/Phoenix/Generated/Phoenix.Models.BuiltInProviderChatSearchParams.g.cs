
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Chat against a Phoenix built-in provider.<br/>
    /// Credentials and connection details (base URL, Azure endpoint, AWS<br/>
    /// region) are resolved from the secret store first and the process<br/>
    /// environment second. ``openai_api_type`` is honoured by the OpenAI and<br/>
    /// Azure OpenAI branches; other providers ignore it.
    /// </summary>
    public sealed partial class BuiltInProviderChatSearchParams
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"builtin"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        public string ProviderType { get; set; } = "builtin";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ModelProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.ModelProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Default Value: responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai_api_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.BuiltInProviderChatSearchParamsOpenaiApiTypeJsonConverter))]
        public global::Phoenix.BuiltInProviderChatSearchParamsOpenaiApiType? OpenaiApiType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInProviderChatSearchParams" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="modelName"></param>
        /// <param name="openaiApiType">
        /// Default Value: responses
        /// </param>
        /// <param name="providerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltInProviderChatSearchParams(
            global::Phoenix.ModelProvider provider,
            string modelName,
            global::Phoenix.BuiltInProviderChatSearchParamsOpenaiApiType? openaiApiType,
            string providerType = "builtin")
        {
            this.ProviderType = providerType;
            this.Provider = provider;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.OpenaiApiType = openaiApiType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInProviderChatSearchParams" /> class.
        /// </summary>
        public BuiltInProviderChatSearchParams()
        {
        }
    }
}