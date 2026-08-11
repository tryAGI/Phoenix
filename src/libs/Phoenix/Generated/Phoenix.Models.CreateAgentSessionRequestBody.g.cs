
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Request body for creating a persisted agent session.
    /// </summary>
    public sealed partial class CreateAgentSessionRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AgentModelSelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AgentModelSelection Model { get; set; }

        /// <summary>
        /// Optional initial title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Whether the session should expire after a period of inactivity.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_ephemeral")]
        public bool? IsEphemeral { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequestBody" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="title">
        /// Optional initial title.
        /// </param>
        /// <param name="isEphemeral">
        /// Whether the session should expire after a period of inactivity.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionRequestBody(
            global::Phoenix.AgentModelSelection model,
            string? title,
            bool? isEphemeral)
        {
            this.Model = model;
            this.Title = title;
            this.IsEphemeral = isEphemeral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequestBody" /> class.
        /// </summary>
        public CreateAgentSessionRequestBody()
        {
        }

    }
}