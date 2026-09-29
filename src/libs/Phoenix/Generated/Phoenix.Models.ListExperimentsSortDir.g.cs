
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Order by creation: 'desc' (default) returns newest experiments first, 'asc' returns oldest first so the lowest sequence numbers are on the first page.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListExperimentsSortDir
    {
        /// <summary>
        /// 'desc' (default) returns newest experiments first, 'asc' returns oldest first so the lowest sequence numbers are on the first page.
        /// </summary>
        Asc,
        /// <summary>
        /// 'desc' (default) returns newest experiments first, 'asc' returns oldest first so the lowest sequence numbers are on the first page.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExperimentsSortDirExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExperimentsSortDir value)
        {
            return value switch
            {
                ListExperimentsSortDir.Asc => "asc",
                ListExperimentsSortDir.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExperimentsSortDir? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListExperimentsSortDir.Asc,
                "desc" => ListExperimentsSortDir.Desc,
                _ => null,
            };
        }
    }
}