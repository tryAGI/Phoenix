
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum TraceAnnotationAnnotatorKind
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
    public static class TraceAnnotationAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceAnnotationAnnotatorKind value)
        {
            return value switch
            {
                TraceAnnotationAnnotatorKind.Agent => "AGENT",
                TraceAnnotationAnnotatorKind.Code => "CODE",
                TraceAnnotationAnnotatorKind.Decision => "DECISION",
                TraceAnnotationAnnotatorKind.Human => "HUMAN",
                TraceAnnotationAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceAnnotationAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => TraceAnnotationAnnotatorKind.Agent,
                "CODE" => TraceAnnotationAnnotatorKind.Code,
                "DECISION" => TraceAnnotationAnnotatorKind.Decision,
                "HUMAN" => TraceAnnotationAnnotatorKind.Human,
                "LLM" => TraceAnnotationAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}