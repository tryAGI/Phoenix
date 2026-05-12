
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanNoteData
    {
        /// <summary>
        /// OpenTelemetry Span ID (hex format w/o 0x prefix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// The note text to add to the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Note { get; set; }

        /// <summary>
        /// Optional caller-supplied identifier. When non-empty, the note is upserted on (span_id, name='note', identifier) — repeated calls with the same identifier overwrite the existing note. When omitted or empty, the server stamps a unique 'px-span-note:&lt;uuid&gt;' identifier so each call appends a new note.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanNoteData" /> class.
        /// </summary>
        /// <param name="spanId">
        /// OpenTelemetry Span ID (hex format w/o 0x prefix)
        /// </param>
        /// <param name="note">
        /// The note text to add to the span
        /// </param>
        /// <param name="identifier">
        /// Optional caller-supplied identifier. When non-empty, the note is upserted on (span_id, name='note', identifier) — repeated calls with the same identifier overwrite the existing note. When omitted or empty, the server stamps a unique 'px-span-note:&lt;uuid&gt;' identifier so each call appends a new note.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpanNoteData(
            string spanId,
            string note,
            string? identifier)
        {
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanNoteData" /> class.
        /// </summary>
        public SpanNoteData()
        {
        }

    }
}