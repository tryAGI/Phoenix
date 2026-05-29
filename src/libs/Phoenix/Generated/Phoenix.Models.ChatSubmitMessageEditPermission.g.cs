
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: manual
    /// </summary>
    public enum ChatSubmitMessageEditPermission
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
    public static class ChatSubmitMessageEditPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSubmitMessageEditPermission value)
        {
            return value switch
            {
                ChatSubmitMessageEditPermission.Bypass => "bypass",
                ChatSubmitMessageEditPermission.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSubmitMessageEditPermission? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => ChatSubmitMessageEditPermission.Bypass,
                "manual" => ChatSubmitMessageEditPermission.Manual,
                _ => null,
            };
        }
    }
}