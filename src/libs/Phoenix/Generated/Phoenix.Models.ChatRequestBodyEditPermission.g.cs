
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: manual
    /// </summary>
    public enum ChatRequestBodyEditPermission
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
    public static class ChatRequestBodyEditPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestBodyEditPermission value)
        {
            return value switch
            {
                ChatRequestBodyEditPermission.Bypass => "bypass",
                ChatRequestBodyEditPermission.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestBodyEditPermission? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => ChatRequestBodyEditPermission.Bypass,
                "manual" => ChatRequestBodyEditPermission.Manual,
                _ => null,
            };
        }
    }
}