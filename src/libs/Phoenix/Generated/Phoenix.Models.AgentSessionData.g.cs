
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSessionData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_ephemeral")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEphemeral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AgentModelSelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AgentModelSelection Model { get; set; }

        /// <summary>
        /// Whether a response is currently streaming on this session, i.e. its lock has a live (non-stale) heartbeat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// The message ID of the most recently persisted transcript message, or null for an empty transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_message_id")]
        public string? LastMessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="isEphemeral"></param>
        /// <param name="model"></param>
        /// <param name="isActive">
        /// Whether a response is currently streaming on this session, i.e. its lock has a live (non-stale) heartbeat.
        /// </param>
        /// <param name="lastMessageId">
        /// The message ID of the most recently persisted transcript message, or null for an empty transcript.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionData(
            string id,
            string title,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool isEphemeral,
            global::Phoenix.AgentModelSelection model,
            bool isActive,
            string? lastMessageId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsEphemeral = isEphemeral;
            this.Model = model;
            this.IsActive = isActive;
            this.LastMessageId = lastMessageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionData" /> class.
        /// </summary>
        public AgentSessionData()
        {
        }

    }
}