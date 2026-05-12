
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Chat against a stored custom provider record.
    /// </summary>
    public sealed partial class CustomProviderModelSelection
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerType")]
        public string ProviderType { get; set; } = "custom";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

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
        /// Initializes a new instance of the <see cref="CustomProviderModelSelection" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="modelName"></param>
        /// <param name="providerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomProviderModelSelection(
            string providerId,
            string modelName,
            string providerType = "custom")
        {
            this.ProviderType = providerType;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProviderModelSelection" /> class.
        /// </summary>
        public CustomProviderModelSelection()
        {
        }

    }
}