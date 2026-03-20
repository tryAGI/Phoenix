
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionAnnotationData
    {
        /// <summary>
        /// The name of the annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The kind of annotator used for the annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.SessionAnnotationDataAnnotatorKind AnnotatorKind { get; set; }

        /// <summary>
        /// The result of the annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Phoenix.AnnotationResult? Result { get; set; }

        /// <summary>
        /// Metadata for the annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The identifier of the annotation. If provided, the annotation will be updated if it already exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Session ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionAnnotationData" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the annotation
        /// </param>
        /// <param name="annotatorKind">
        /// The kind of annotator used for the annotation
        /// </param>
        /// <param name="result">
        /// The result of the annotation
        /// </param>
        /// <param name="metadata">
        /// Metadata for the annotation
        /// </param>
        /// <param name="identifier">
        /// The identifier of the annotation. If provided, the annotation will be updated if it already exists.
        /// </param>
        /// <param name="sessionId">
        /// Session ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionAnnotationData(
            string name,
            global::Phoenix.SessionAnnotationDataAnnotatorKind annotatorKind,
            string sessionId,
            global::Phoenix.AnnotationResult? result,
            object? metadata,
            string? identifier)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AnnotatorKind = annotatorKind;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Result = result;
            this.Metadata = metadata;
            this.Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionAnnotationData" /> class.
        /// </summary>
        public SessionAnnotationData()
        {
        }
    }
}