
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.SessionTraceData> Traces { get; set; }

        /// <summary>
        /// Cumulative prompt token count across all spans in the session.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count_prompt")]
        public int? TokenCountPrompt { get; set; }

        /// <summary>
        /// Cumulative completion token count across all spans in the session.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count_completion")]
        public int? TokenCountCompletion { get; set; }

        /// <summary>
        /// Cumulative total token count across all spans in the session (prompt + completion).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count_total")]
        public int? TokenCountTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="projectId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="traces"></param>
        /// <param name="tokenCountPrompt">
        /// Cumulative prompt token count across all spans in the session.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="tokenCountCompletion">
        /// Cumulative completion token count across all spans in the session.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="tokenCountTotal">
        /// Cumulative total token count across all spans in the session (prompt + completion).<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionData(
            string id,
            string sessionId,
            string projectId,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::Phoenix.SessionTraceData> traces,
            int? tokenCountPrompt,
            int? tokenCountCompletion,
            int? tokenCountTotal)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
            this.TokenCountPrompt = tokenCountPrompt;
            this.TokenCountCompletion = tokenCountCompletion;
            this.TokenCountTotal = tokenCountTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionData" /> class.
        /// </summary>
        public SessionData()
        {
        }

    }
}