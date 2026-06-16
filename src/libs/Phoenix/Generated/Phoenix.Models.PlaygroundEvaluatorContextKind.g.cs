
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundEvaluatorContextKind
    {
        /// <summary>
        /// 
        /// </summary>
        Builtin,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundEvaluatorContextKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundEvaluatorContextKind value)
        {
            return value switch
            {
                PlaygroundEvaluatorContextKind.Builtin => "BUILTIN",
                PlaygroundEvaluatorContextKind.Code => "CODE",
                PlaygroundEvaluatorContextKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundEvaluatorContextKind? ToEnum(string value)
        {
            return value switch
            {
                "BUILTIN" => PlaygroundEvaluatorContextKind.Builtin,
                "CODE" => PlaygroundEvaluatorContextKind.Code,
                "LLM" => PlaygroundEvaluatorContextKind.Llm,
                _ => null,
            };
        }
    }
}