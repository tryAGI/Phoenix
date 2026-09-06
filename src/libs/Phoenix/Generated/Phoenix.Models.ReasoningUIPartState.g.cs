
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum ReasoningUIPartState
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
    public static class ReasoningUIPartStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningUIPartState value)
        {
            return value switch
            {
                ReasoningUIPartState.Done => "done",
                ReasoningUIPartState.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningUIPartState? ToEnum(string value)
        {
            return value switch
            {
                "done" => ReasoningUIPartState.Done,
                "streaming" => ReasoningUIPartState.Streaming,
                _ => null,
            };
        }
    }
}