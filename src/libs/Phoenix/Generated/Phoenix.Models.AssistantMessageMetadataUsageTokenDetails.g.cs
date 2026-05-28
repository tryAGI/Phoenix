
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageMetadataUsageTokenDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheRead")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWrite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheWrite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsageTokenDetails" /> class.
        /// </summary>
        /// <param name="cacheRead"></param>
        /// <param name="cacheWrite"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageMetadataUsageTokenDetails(
            int cacheRead,
            int cacheWrite)
        {
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsageTokenDetails" /> class.
        /// </summary>
        public AssistantMessageMetadataUsageTokenDetails()
        {
        }

    }
}