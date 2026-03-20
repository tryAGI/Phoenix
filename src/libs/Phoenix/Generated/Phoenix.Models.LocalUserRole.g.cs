
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalUserRole
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
    public static class LocalUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalUserRole value)
        {
            return value switch
            {
                LocalUserRole.System => "SYSTEM",
                LocalUserRole.Admin => "ADMIN",
                LocalUserRole.Member => "MEMBER",
                LocalUserRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalUserRole? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => LocalUserRole.System,
                "ADMIN" => LocalUserRole.Admin,
                "MEMBER" => LocalUserRole.Member,
                "VIEWER" => LocalUserRole.Viewer,
                _ => null,
            };
        }
    }
}