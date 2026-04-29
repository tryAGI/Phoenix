
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
        Append,
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Update,
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
                UploadDatasetRequestAction2.Append => "append",
                UploadDatasetRequestAction2.Create => "create",
                UploadDatasetRequestAction2.Update => "update",
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
                "append" => UploadDatasetRequestAction2.Append,
                "create" => UploadDatasetRequestAction2.Create,
                "update" => UploadDatasetRequestAction2.Update,
                _ => null,
            };
        }
    }
}