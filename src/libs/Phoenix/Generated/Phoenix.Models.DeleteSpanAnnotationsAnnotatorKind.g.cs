
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteSpanAnnotationsAnnotatorKind
    {
        /// <summary>
        ///
        /// </summary>
        Code,
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
    public static class DeleteSpanAnnotationsAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSpanAnnotationsAnnotatorKind value)
        {
            return value switch
            {
                DeleteSpanAnnotationsAnnotatorKind.Code => "CODE",
                DeleteSpanAnnotationsAnnotatorKind.Human => "HUMAN",
                DeleteSpanAnnotationsAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSpanAnnotationsAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => DeleteSpanAnnotationsAnnotatorKind.Code,
                "HUMAN" => DeleteSpanAnnotationsAnnotatorKind.Human,
                "LLM" => DeleteSpanAnnotationsAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}