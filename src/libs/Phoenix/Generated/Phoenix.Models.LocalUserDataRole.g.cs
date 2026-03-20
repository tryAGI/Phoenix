
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalUserDataRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalUserDataRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalUserDataRole value)
        {
            return value switch
            {
                LocalUserDataRole.System => "SYSTEM",
                LocalUserDataRole.Admin => "ADMIN",
                LocalUserDataRole.Member => "MEMBER",
                LocalUserDataRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalUserDataRole? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => LocalUserDataRole.System,
                "ADMIN" => LocalUserDataRole.Admin,
                "MEMBER" => LocalUserDataRole.Member,
                "VIEWER" => LocalUserDataRole.Viewer,
                _ => null,
            };
        }
    }
}