
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: manual
    /// </summary>
    public enum LegacyChatSubmitMessageEditPermission
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
    public static class LegacyChatSubmitMessageEditPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyChatSubmitMessageEditPermission value)
        {
            return value switch
            {
                LegacyChatSubmitMessageEditPermission.Bypass => "bypass",
                LegacyChatSubmitMessageEditPermission.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyChatSubmitMessageEditPermission? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => LegacyChatSubmitMessageEditPermission.Bypass,
                "manual" => LegacyChatSubmitMessageEditPermission.Manual,
                _ => null,
            };
        }
    }
}