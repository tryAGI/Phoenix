
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum SpanDocumentAnnotationDataAnnotatorKind
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Code,
        /// <summary>
        ///
        /// </summary>
        Decision,
        /// <summary>
        ///
        /// </summary>
        Human,
        /// <summary>
        ///
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanDocumentAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanDocumentAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                SpanDocumentAnnotationDataAnnotatorKind.Agent => "AGENT",
                SpanDocumentAnnotationDataAnnotatorKind.Code => "CODE",
                SpanDocumentAnnotationDataAnnotatorKind.Decision => "DECISION",
                SpanDocumentAnnotationDataAnnotatorKind.Human => "HUMAN",
                SpanDocumentAnnotationDataAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanDocumentAnnotationDataAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => SpanDocumentAnnotationDataAnnotatorKind.Agent,
                "CODE" => SpanDocumentAnnotationDataAnnotatorKind.Code,
                "DECISION" => SpanDocumentAnnotationDataAnnotatorKind.Decision,
                "HUMAN" => SpanDocumentAnnotationDataAnnotatorKind.Human,
                "LLM" => SpanDocumentAnnotationDataAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}