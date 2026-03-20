
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum OtlpDoubleValue
    {
        /// <summary>
        /// 
        /// </summary>
        Infinity,
        /// <summary>
        /// 
        /// </summary>
        MinusInfinity,
        /// <summary>
        /// 
        /// </summary>
        NaN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OtlpDoubleValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OtlpDoubleValue value)
        {
            return value switch
            {
                OtlpDoubleValue.Infinity => "Infinity",
                OtlpDoubleValue.MinusInfinity => "-Infinity",
                OtlpDoubleValue.NaN => "NaN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OtlpDoubleValue? ToEnum(string value)
        {
            return value switch
            {
                "Infinity" => OtlpDoubleValue.Infinity,
                "-Infinity" => OtlpDoubleValue.MinusInfinity,
                "NaN" => OtlpDoubleValue.NaN,
                _ => null,
            };
        }
    }
}