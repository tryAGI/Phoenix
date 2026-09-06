
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum TextUIPartState
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
    public static class TextUIPartStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextUIPartState value)
        {
            return value switch
            {
                TextUIPartState.Done => "done",
                TextUIPartState.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextUIPartState? ToEnum(string value)
        {
            return value switch
            {
                "done" => TextUIPartState.Done,
                "streaming" => TextUIPartState.Streaming,
                _ => null,
            };
        }
    }
}