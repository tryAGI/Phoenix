
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum SpanAnnotationDataAnnotatorKind
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
    public static class SpanAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                SpanAnnotationDataAnnotatorKind.Llm => "LLM",
                SpanAnnotationDataAnnotatorKind.Code => "CODE",
                SpanAnnotationDataAnnotatorKind.Human => "HUMAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanAnnotationDataAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "LLM" => SpanAnnotationDataAnnotatorKind.Llm,
                "CODE" => SpanAnnotationDataAnnotatorKind.Code,
                "HUMAN" => SpanAnnotationDataAnnotatorKind.Human,
                _ => null,
            };
        }
    }
}