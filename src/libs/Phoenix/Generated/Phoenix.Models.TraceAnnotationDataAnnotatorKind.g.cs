
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum TraceAnnotationDataAnnotatorKind
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
    public static class TraceAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                TraceAnnotationDataAnnotatorKind.Llm => "LLM",
                TraceAnnotationDataAnnotatorKind.Code => "CODE",
                TraceAnnotationDataAnnotatorKind.Human => "HUMAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceAnnotationDataAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "LLM" => TraceAnnotationDataAnnotatorKind.Llm,
                "CODE" => TraceAnnotationDataAnnotatorKind.Code,
                "HUMAN" => TraceAnnotationDataAnnotatorKind.Human,
                _ => null,
            };
        }
    }
}