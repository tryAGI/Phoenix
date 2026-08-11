
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Prompt-cache token counts, mounted as the usage payload's<br/>
    /// ``prompt_details`` because cached tokens are a breakdown of the prompt.
    /// </summary>
    public sealed partial class AssistantMessageMetadataUsageCacheTokenDetails
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
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsageCacheTokenDetails" /> class.
        /// </summary>
        /// <param name="cacheRead"></param>
        /// <param name="cacheWrite"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageMetadataUsageCacheTokenDetails(
            int cacheRead,
            int cacheWrite)
        {
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsageCacheTokenDetails" /> class.
        /// </summary>
        public AssistantMessageMetadataUsageCacheTokenDetails()
        {
        }

    }
}