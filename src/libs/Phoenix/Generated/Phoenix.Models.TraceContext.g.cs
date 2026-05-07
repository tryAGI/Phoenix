
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"trace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "trace";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otelTraceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OtelTraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceContext" /> class.
        /// </summary>
        /// <param name="projectNodeId"></param>
        /// <param name="otelTraceId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceContext(
            string projectNodeId,
            string otelTraceId,
            string type = "trace")
        {
            this.Type = type;
            this.ProjectNodeId = projectNodeId ?? throw new global::System.ArgumentNullException(nameof(projectNodeId));
            this.OtelTraceId = otelTraceId ?? throw new global::System.ArgumentNullException(nameof(otelTraceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceContext" /> class.
        /// </summary>
        public TraceContext()
        {
        }
    }
}