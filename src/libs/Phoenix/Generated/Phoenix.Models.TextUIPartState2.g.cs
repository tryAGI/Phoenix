
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextUIPartState2
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
    public static class TextUIPartState2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextUIPartState2 value)
        {
            return value switch
            {
                TextUIPartState2.Done => "done",
                TextUIPartState2.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextUIPartState2? ToEnum(string value)
        {
            return value switch
            {
                "done" => TextUIPartState2.Done,
                "streaming" => TextUIPartState2.Streaming,
                _ => null,
            };
        }
    }
}