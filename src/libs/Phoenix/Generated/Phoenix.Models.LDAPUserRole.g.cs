
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum LDAPUserRole
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
    public static class LDAPUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LDAPUserRole value)
        {
            return value switch
            {
                LDAPUserRole.System => "SYSTEM",
                LDAPUserRole.Admin => "ADMIN",
                LDAPUserRole.Member => "MEMBER",
                LDAPUserRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LDAPUserRole? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => LDAPUserRole.System,
                "ADMIN" => LDAPUserRole.Admin,
                "MEMBER" => LDAPUserRole.Member,
                "VIEWER" => LDAPUserRole.Viewer,
                _ => null,
            };
        }
    }
}