
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoenixUIMessageRole
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
    public static class PhoenixUIMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoenixUIMessageRole value)
        {
            return value switch
            {
                PhoenixUIMessageRole.Assistant => "assistant",
                PhoenixUIMessageRole.System => "system",
                PhoenixUIMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoenixUIMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => PhoenixUIMessageRole.Assistant,
                "system" => PhoenixUIMessageRole.System,
                "user" => PhoenixUIMessageRole.User,
                _ => null,
            };
        }
    }
}