
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptPersistedData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPersistedData" /> class.
        /// </summary>
        /// <param name="messageId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptPersistedData(
            string messageId)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPersistedData" /> class.
        /// </summary>
        public TranscriptPersistedData()
        {
        }

    }
}