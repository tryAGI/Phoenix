
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadDatasetRequestAction
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
    public static class UploadDatasetRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadDatasetRequestAction value)
        {
            return value switch
            {
                UploadDatasetRequestAction.Create => "create",
                UploadDatasetRequestAction.Append => "append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadDatasetRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "create" => UploadDatasetRequestAction.Create,
                "append" => UploadDatasetRequestAction.Append,
                _ => null,
            };
        }
    }
}