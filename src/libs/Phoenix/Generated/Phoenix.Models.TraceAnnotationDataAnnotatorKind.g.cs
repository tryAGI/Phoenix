
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
    public static class TraceAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                TraceAnnotationDataAnnotatorKind.Agent => "AGENT",
                TraceAnnotationDataAnnotatorKind.Code => "CODE",
                TraceAnnotationDataAnnotatorKind.Decision => "DECISION",
                TraceAnnotationDataAnnotatorKind.Human => "HUMAN",
                TraceAnnotationDataAnnotatorKind.Llm => "LLM",
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
                "AGENT" => TraceAnnotationDataAnnotatorKind.Agent,
                "CODE" => TraceAnnotationDataAnnotatorKind.Code,
                "DECISION" => TraceAnnotationDataAnnotatorKind.Decision,
                "HUMAN" => TraceAnnotationDataAnnotatorKind.Human,
                "LLM" => TraceAnnotationDataAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}