
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageMetadataTraceIds
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootSpanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootSpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataTraceIds" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="rootSpanId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageMetadataTraceIds(
            string traceId,
            string rootSpanId)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.RootSpanId = rootSpanId ?? throw new global::System.ArgumentNullException(nameof(rootSpanId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataTraceIds" /> class.
        /// </summary>
        public AssistantMessageMetadataTraceIds()
        {
        }

    }
}