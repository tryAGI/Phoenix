
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Confirms that a streamed assistant message is durable.
    /// </summary>
    public sealed partial class TranscriptPersistedChunk
    {
        /// <summary>
        /// Default Value: data-transcript-persisted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.TranscriptPersistedData Data { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transient")]
        public bool? Transient { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPersistedChunk" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// Default Value: data-transcript-persisted
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transient">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptPersistedChunk(
            global::Phoenix.TranscriptPersistedData data,
            string? type,
            string? id,
            bool? transient)
        {
            this.Type = type;
            this.Id = id;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Transient = transient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPersistedChunk" /> class.
        /// </summary>
        public TranscriptPersistedChunk()
        {
        }

    }
}