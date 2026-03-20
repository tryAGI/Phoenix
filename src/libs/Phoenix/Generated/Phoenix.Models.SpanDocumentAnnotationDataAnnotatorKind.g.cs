
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
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Human,
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
                SpanDocumentAnnotationDataAnnotatorKind.Llm => "LLM",
                SpanDocumentAnnotationDataAnnotatorKind.Code => "CODE",
                SpanDocumentAnnotationDataAnnotatorKind.Human => "HUMAN",
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
                "LLM" => SpanDocumentAnnotationDataAnnotatorKind.Llm,
                "CODE" => SpanDocumentAnnotationDataAnnotatorKind.Code,
                "HUMAN" => SpanDocumentAnnotationDataAnnotatorKind.Human,
                _ => null,
            };
        }
    }
}