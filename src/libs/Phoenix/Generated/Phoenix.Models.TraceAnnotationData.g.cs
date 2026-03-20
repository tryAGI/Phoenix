
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceAnnotationData
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.TraceAnnotationDataAnnotatorKind AnnotatorKind { get; set; }

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
        /// OpenTelemetry Trace ID (hex format w/o 0x prefix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceAnnotationData" /> class.
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
        /// <param name="traceId">
        /// OpenTelemetry Trace ID (hex format w/o 0x prefix)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceAnnotationData(
            string name,
            global::Phoenix.TraceAnnotationDataAnnotatorKind annotatorKind,
            string traceId,
            global::Phoenix.AnnotationResult? result,
            object? metadata,
            string? identifier)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AnnotatorKind = annotatorKind;
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.Result = result;
            this.Metadata = metadata;
            this.Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceAnnotationData" /> class.
        /// </summary>
        public TraceAnnotationData()
        {
        }
    }
}