
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadDatasetRequestAction2
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Append,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadDatasetRequestAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadDatasetRequestAction2 value)
        {
            return value switch
            {
                UploadDatasetRequestAction2.Create => "create",
                UploadDatasetRequestAction2.Append => "append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadDatasetRequestAction2? ToEnum(string value)
        {
            return value switch
            {
                "create" => UploadDatasetRequestAction2.Create,
                "append" => UploadDatasetRequestAction2.Append,
                _ => null,
            };
        }
    }
}