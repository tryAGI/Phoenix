
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum OAuth2UserDataRole
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
    public static class OAuth2UserDataRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2UserDataRole value)
        {
            return value switch
            {
                OAuth2UserDataRole.System => "SYSTEM",
                OAuth2UserDataRole.Admin => "ADMIN",
                OAuth2UserDataRole.Member => "MEMBER",
                OAuth2UserDataRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2UserDataRole? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => OAuth2UserDataRole.System,
                "ADMIN" => OAuth2UserDataRole.Admin,
                "MEMBER" => OAuth2UserDataRole.Member,
                "VIEWER" => OAuth2UserDataRole.Viewer,
                _ => null,
            };
        }
    }
}