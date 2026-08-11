
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: manual
    /// </summary>
    public enum LegacyChatRegenerateMessageEditPermission
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
    public static class LegacyChatRegenerateMessageEditPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyChatRegenerateMessageEditPermission value)
        {
            return value switch
            {
                LegacyChatRegenerateMessageEditPermission.Bypass => "bypass",
                LegacyChatRegenerateMessageEditPermission.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyChatRegenerateMessageEditPermission? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => LegacyChatRegenerateMessageEditPermission.Bypass,
                "manual" => LegacyChatRegenerateMessageEditPermission.Manual,
                _ => null,
            };
        }
    }
}