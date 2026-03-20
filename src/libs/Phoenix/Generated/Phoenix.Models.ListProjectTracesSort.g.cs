
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Sort field<br/>
    /// Default Value: start_time
    /// </summary>
    public enum ListProjectTracesSort
    {
        /// <summary>
        /// 
        /// </summary>
        StartTime,
        /// <summary>
        /// 
        /// </summary>
        LatencyMs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectTracesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectTracesSort value)
        {
            return value switch
            {
                ListProjectTracesSort.StartTime => "start_time",
                ListProjectTracesSort.LatencyMs => "latency_ms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectTracesSort? ToEnum(string value)
        {
            return value switch
            {
                "start_time" => ListProjectTracesSort.StartTime,
                "latency_ms" => ListProjectTracesSort.LatencyMs,
                _ => null,
            };
        }
    }
}