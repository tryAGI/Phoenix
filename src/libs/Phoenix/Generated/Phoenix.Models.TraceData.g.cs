
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Cumulative prompt token count across all spans in the trace.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count_prompt")]
        public int? TokenCountPrompt { get; set; }

        /// <summary>
        /// Cumulative completion token count across all spans in the trace.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count_completion")]
        public int? TokenCountCompletion { get; set; }

        /// <summary>
        /// Cumulative total token count across all spans in the trace (prompt + completion).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count_total")]
        public int? TokenCountTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Phoenix.TraceSpanData>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
        /// <param name="projectId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="tokenCountPrompt">
        /// Cumulative prompt token count across all spans in the trace.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="tokenCountCompletion">
        /// Cumulative completion token count across all spans in the trace.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="tokenCountTotal">
        /// Cumulative total token count across all spans in the trace (prompt + completion).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="spans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceData(
            string id,
            string traceId,
            string projectId,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int? tokenCountPrompt,
            int? tokenCountCompletion,
            int? tokenCountTotal,
            global::System.Collections.Generic.IList<global::Phoenix.TraceSpanData>? spans)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TokenCountPrompt = tokenCountPrompt;
            this.TokenCountCompletion = tokenCountCompletion;
            this.TokenCountTotal = tokenCountTotal;
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceData" /> class.
        /// </summary>
        public TraceData()
        {
        }

    }
}