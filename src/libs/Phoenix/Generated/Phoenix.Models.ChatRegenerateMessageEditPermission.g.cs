
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: manual
    /// </summary>
    public enum ChatRegenerateMessageEditPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Bypass,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRegenerateMessageEditPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRegenerateMessageEditPermission value)
        {
            return value switch
            {
                ChatRegenerateMessageEditPermission.Bypass => "bypass",
                ChatRegenerateMessageEditPermission.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRegenerateMessageEditPermission? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => ChatRegenerateMessageEditPermission.Bypass,
                "manual" => ChatRegenerateMessageEditPermission.Manual,
                _ => null,
            };
        }
    }
}