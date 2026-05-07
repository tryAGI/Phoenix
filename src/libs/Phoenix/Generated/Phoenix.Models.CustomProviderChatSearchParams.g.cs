
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Chat against a stored custom provider record.<br/>
    /// The wire format of ``provider_id`` is a relay GlobalID (e.g.<br/>
    /// ``UHJvdmlkZXI6MTM=``). It is decoded to its integer node ID at<br/>
    /// parse time so downstream consumers don't need to know the GlobalID<br/>
    /// encoding.
    /// </summary>
    public sealed partial class CustomProviderChatSearchParams
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        public string ProviderType { get; set; } = "custom";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProviderChatSearchParams" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="modelName"></param>
        /// <param name="providerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomProviderChatSearchParams(
            int providerId,
            string modelName,
            string providerType = "custom")
        {
            this.ProviderType = providerType;
            this.ProviderId = providerId;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProviderChatSearchParams" /> class.
        /// </summary>
        public CustomProviderChatSearchParams()
        {
        }
    }
}