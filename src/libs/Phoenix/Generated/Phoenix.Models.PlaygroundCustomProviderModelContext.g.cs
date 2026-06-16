
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Custom-provider playground model selection.
    /// </summary>
    public sealed partial class PlaygroundCustomProviderModelContext
    {
        /// <summary>
        /// Default Value: custom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customProviderId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customProviderName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundCustomProviderModelContext" /> class.
        /// </summary>
        /// <param name="customProviderId"></param>
        /// <param name="customProviderName"></param>
        /// <param name="provider"></param>
        /// <param name="modelName"></param>
        /// <param name="type">
        /// Default Value: custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundCustomProviderModelContext(
            string customProviderId,
            string customProviderName,
            string provider,
            string modelName,
            string? type)
        {
            this.Type = type;
            this.CustomProviderId = customProviderId ?? throw new global::System.ArgumentNullException(nameof(customProviderId));
            this.CustomProviderName = customProviderName ?? throw new global::System.ArgumentNullException(nameof(customProviderName));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundCustomProviderModelContext" /> class.
        /// </summary>
        public PlaygroundCustomProviderModelContext()
        {
        }

    }
}