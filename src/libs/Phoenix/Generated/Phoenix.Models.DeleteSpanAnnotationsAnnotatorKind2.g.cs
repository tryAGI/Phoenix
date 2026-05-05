
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteSpanAnnotationsAnnotatorKind2
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
    public static class DeleteSpanAnnotationsAnnotatorKind2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSpanAnnotationsAnnotatorKind2 value)
        {
            return value switch
            {
                DeleteSpanAnnotationsAnnotatorKind2.Code => "CODE",
                DeleteSpanAnnotationsAnnotatorKind2.Human => "HUMAN",
                DeleteSpanAnnotationsAnnotatorKind2.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSpanAnnotationsAnnotatorKind2? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => DeleteSpanAnnotationsAnnotatorKind2.Code,
                "HUMAN" => DeleteSpanAnnotationsAnnotatorKind2.Human,
                "LLM" => DeleteSpanAnnotationsAnnotatorKind2.Llm,
                _ => null,
            };
        }
    }
}