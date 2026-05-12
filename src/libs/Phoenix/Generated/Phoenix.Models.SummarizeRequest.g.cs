
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Body for POST /agents/{agent_id}/sessions/{session_id}/summary.<br/>
    /// Carries the Vercel-style messages array; the backend owns the prompt and<br/>
    /// the structured-output tool schema.
    /// </summary>
    public sealed partial class SummarizeRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestTraces")]
        public bool? IngestTraces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportRemoteTraces")]
        public bool? ExportRemoteTraces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.UIMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.Model3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.Model3 Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model"></param>
        /// <param name="ingestTraces">
        /// Default Value: false
        /// </param>
        /// <param name="exportRemoteTraces">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizeRequest(
            global::System.Collections.Generic.IList<global::Phoenix.UIMessage> messages,
            global::Phoenix.Model3 model,
            bool? ingestTraces,
            bool? exportRemoteTraces)
        {
            this.IngestTraces = ingestTraces;
            this.ExportRemoteTraces = exportRemoteTraces;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeRequest" /> class.
        /// </summary>
        public SummarizeRequest()
        {
        }

    }
}