
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningUIPartState2
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningUIPartState2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningUIPartState2 value)
        {
            return value switch
            {
                ReasoningUIPartState2.Done => "done",
                ReasoningUIPartState2.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningUIPartState2? ToEnum(string value)
        {
            return value switch
            {
                "done" => ReasoningUIPartState2.Done,
                "streaming" => ReasoningUIPartState2.Streaming,
                _ => null,
            };
        }
    }
}