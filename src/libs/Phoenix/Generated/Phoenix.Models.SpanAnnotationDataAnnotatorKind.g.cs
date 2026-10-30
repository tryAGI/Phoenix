
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
    public static class SpanAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                SpanAnnotationDataAnnotatorKind.Agent => "AGENT",
                SpanAnnotationDataAnnotatorKind.Code => "CODE",
                SpanAnnotationDataAnnotatorKind.Decision => "DECISION",
                SpanAnnotationDataAnnotatorKind.Human => "HUMAN",
                SpanAnnotationDataAnnotatorKind.Llm => "LLM",
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
                "AGENT" => SpanAnnotationDataAnnotatorKind.Agent,
                "CODE" => SpanAnnotationDataAnnotatorKind.Code,
                "DECISION" => SpanAnnotationDataAnnotatorKind.Decision,
                "HUMAN" => SpanAnnotationDataAnnotatorKind.Human,
                "LLM" => SpanAnnotationDataAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}