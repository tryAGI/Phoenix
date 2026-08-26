
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: manual
    /// </summary>
    public enum PhoenixUserMessageMetadataEditPermission
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
    public static class PhoenixUserMessageMetadataEditPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoenixUserMessageMetadataEditPermission value)
        {
            return value switch
            {
                PhoenixUserMessageMetadataEditPermission.Bypass => "bypass",
                PhoenixUserMessageMetadataEditPermission.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoenixUserMessageMetadataEditPermission? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PhoenixUserMessageMetadataEditPermission.Bypass,
                "manual" => PhoenixUserMessageMetadataEditPermission.Manual,
                _ => null,
            };
        }
    }
}