
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetExampleSource2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExampleSource2" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="spanNodeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetExampleSource2(
            string spanId,
            string spanNodeId)
        {
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.SpanNodeId = spanNodeId ?? throw new global::System.ArgumentNullException(nameof(spanNodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExampleSource2" /> class.
        /// </summary>
        public DatasetExampleSource2()
        {
        }

    }
}