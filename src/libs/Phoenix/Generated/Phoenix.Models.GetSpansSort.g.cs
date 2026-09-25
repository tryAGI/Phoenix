
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Sort field. 'id' orders by insertion; 'start_time' orders by when the span started, breaking ties by id.<br/>
    /// Default Value: id
    /// </summary>
    public enum GetSpansSort
    {
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        StartTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpansSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpansSort value)
        {
            return value switch
            {
                GetSpansSort.Id => "id",
                GetSpansSort.StartTime => "start_time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpansSort? ToEnum(string value)
        {
            return value switch
            {
                "id" => GetSpansSort.Id,
                "start_time" => GetSpansSort.StartTime,
                _ => null,
            };
        }
    }
}