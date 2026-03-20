
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum LDAPUserDataRole
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
    public static class LDAPUserDataRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LDAPUserDataRole value)
        {
            return value switch
            {
                LDAPUserDataRole.System => "SYSTEM",
                LDAPUserDataRole.Admin => "ADMIN",
                LDAPUserDataRole.Member => "MEMBER",
                LDAPUserDataRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LDAPUserDataRole? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => LDAPUserDataRole.System,
                "ADMIN" => LDAPUserDataRole.Admin,
                "MEMBER" => LDAPUserDataRole.Member,
                "VIEWER" => LDAPUserDataRole.Viewer,
                _ => null,
            };
        }
    }
}