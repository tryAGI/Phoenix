
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaygroundEvaluatorUIContextKind
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
    public static class PlaygroundEvaluatorUIContextKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundEvaluatorUIContextKind value)
        {
            return value switch
            {
                PlaygroundEvaluatorUIContextKind.Builtin => "BUILTIN",
                PlaygroundEvaluatorUIContextKind.Code => "CODE",
                PlaygroundEvaluatorUIContextKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundEvaluatorUIContextKind? ToEnum(string value)
        {
            return value switch
            {
                "BUILTIN" => PlaygroundEvaluatorUIContextKind.Builtin,
                "CODE" => PlaygroundEvaluatorUIContextKind.Code,
                "LLM" => PlaygroundEvaluatorUIContextKind.Llm,
                _ => null,
            };
        }
    }
}