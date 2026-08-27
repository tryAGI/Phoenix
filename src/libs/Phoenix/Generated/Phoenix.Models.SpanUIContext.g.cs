
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpanUIContext
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"span"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "span";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectNodeId")]
        public string? ProjectNodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanNodeId")]
        public string? SpanNodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otelSpanId")]
        public string? OtelSpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanUIContext" /> class.
        /// </summary>
        /// <param name="projectNodeId"></param>
        /// <param name="spanNodeId"></param>
        /// <param name="otelSpanId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpanUIContext(
            string? projectNodeId,
            string? spanNodeId,
            string? otelSpanId,
            string type = "span")
        {
            this.Type = type;
            this.ProjectNodeId = projectNodeId;
            this.SpanNodeId = spanNodeId;
            this.OtelSpanId = otelSpanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanUIContext" /> class.
        /// </summary>
        public SpanUIContext()
        {
        }

    }
}