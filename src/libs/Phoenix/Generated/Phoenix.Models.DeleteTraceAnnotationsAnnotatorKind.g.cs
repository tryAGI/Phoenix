
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteTraceAnnotationsAnnotatorKind
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
    public static class DeleteTraceAnnotationsAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTraceAnnotationsAnnotatorKind value)
        {
            return value switch
            {
                DeleteTraceAnnotationsAnnotatorKind.Code => "CODE",
                DeleteTraceAnnotationsAnnotatorKind.Human => "HUMAN",
                DeleteTraceAnnotationsAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTraceAnnotationsAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => DeleteTraceAnnotationsAnnotatorKind.Code,
                "HUMAN" => DeleteTraceAnnotationsAnnotatorKind.Human,
                "LLM" => DeleteTraceAnnotationsAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}