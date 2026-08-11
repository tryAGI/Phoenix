
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Fields to update on a persisted session. Omit a field to leave it unchanged.
    /// </summary>
    public sealed partial class PatchAgentSessionRequestBody
    {
        /// <summary>
        /// New title for the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// New model selection for the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AgentModelSelectionJsonConverter))]
        public global::Phoenix.AgentModelSelection? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentSessionRequestBody" /> class.
        /// </summary>
        /// <param name="title">
        /// New title for the session
        /// </param>
        /// <param name="model">
        /// New model selection for the session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAgentSessionRequestBody(
            string? title,
            global::Phoenix.AgentModelSelection? model)
        {
            this.Title = title;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentSessionRequestBody" /> class.
        /// </summary>
        public PatchAgentSessionRequestBody()
        {
        }

    }
}