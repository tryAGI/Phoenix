
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum SpanAnnotationAnnotatorKind
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
    public static class SpanAnnotationAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanAnnotationAnnotatorKind value)
        {
            return value switch
            {
                SpanAnnotationAnnotatorKind.Agent => "AGENT",
                SpanAnnotationAnnotatorKind.Code => "CODE",
                SpanAnnotationAnnotatorKind.Decision => "DECISION",
                SpanAnnotationAnnotatorKind.Human => "HUMAN",
                SpanAnnotationAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanAnnotationAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => SpanAnnotationAnnotatorKind.Agent,
                "CODE" => SpanAnnotationAnnotatorKind.Code,
                "DECISION" => SpanAnnotationAnnotatorKind.Decision,
                "HUMAN" => SpanAnnotationAnnotatorKind.Human,
                "LLM" => SpanAnnotationAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}