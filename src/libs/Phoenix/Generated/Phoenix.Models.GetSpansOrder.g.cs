
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Sort direction<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetSpansOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpansOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpansOrder value)
        {
            return value switch
            {
                GetSpansOrder.Asc => "asc",
                GetSpansOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpansOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSpansOrder.Asc,
                "desc" => GetSpansOrder.Desc,
                _ => null,
            };
        }
    }
}