
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteTraceAnnotationsAnnotatorKind2
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
    public static class DeleteTraceAnnotationsAnnotatorKind2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTraceAnnotationsAnnotatorKind2 value)
        {
            return value switch
            {
                DeleteTraceAnnotationsAnnotatorKind2.Code => "CODE",
                DeleteTraceAnnotationsAnnotatorKind2.Human => "HUMAN",
                DeleteTraceAnnotationsAnnotatorKind2.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTraceAnnotationsAnnotatorKind2? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => DeleteTraceAnnotationsAnnotatorKind2.Code,
                "HUMAN" => DeleteTraceAnnotationsAnnotatorKind2.Human,
                "LLM" => DeleteTraceAnnotationsAnnotatorKind2.Llm,
                _ => null,
            };
        }
    }
}