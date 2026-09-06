
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteSessionAnnotationsAnnotatorKind
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
    public static class DeleteSessionAnnotationsAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSessionAnnotationsAnnotatorKind value)
        {
            return value switch
            {
                DeleteSessionAnnotationsAnnotatorKind.Code => "CODE",
                DeleteSessionAnnotationsAnnotatorKind.Human => "HUMAN",
                DeleteSessionAnnotationsAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSessionAnnotationsAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => DeleteSessionAnnotationsAnnotatorKind.Code,
                "HUMAN" => DeleteSessionAnnotationsAnnotatorKind.Human,
                "LLM" => DeleteSessionAnnotationsAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}