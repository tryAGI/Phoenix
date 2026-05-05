
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteSessionAnnotationsAnnotatorKind2
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
    public static class DeleteSessionAnnotationsAnnotatorKind2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSessionAnnotationsAnnotatorKind2 value)
        {
            return value switch
            {
                DeleteSessionAnnotationsAnnotatorKind2.Code => "CODE",
                DeleteSessionAnnotationsAnnotatorKind2.Human => "HUMAN",
                DeleteSessionAnnotationsAnnotatorKind2.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSessionAnnotationsAnnotatorKind2? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => DeleteSessionAnnotationsAnnotatorKind2.Code,
                "HUMAN" => DeleteSessionAnnotationsAnnotatorKind2.Human,
                "LLM" => DeleteSessionAnnotationsAnnotatorKind2.Llm,
                _ => null,
            };
        }
    }
}