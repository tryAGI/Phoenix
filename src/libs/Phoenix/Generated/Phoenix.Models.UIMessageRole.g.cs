
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum UIMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UIMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UIMessageRole value)
        {
            return value switch
            {
                UIMessageRole.Assistant => "assistant",
                UIMessageRole.System => "system",
                UIMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UIMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => UIMessageRole.Assistant,
                "system" => UIMessageRole.System,
                "user" => UIMessageRole.User,
                _ => null,
            };
        }
    }
}