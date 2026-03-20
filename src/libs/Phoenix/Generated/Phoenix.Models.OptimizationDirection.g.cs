
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum OptimizationDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Minimize,
        /// <summary>
        /// 
        /// </summary>
        Maximize,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OptimizationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizationDirection value)
        {
            return value switch
            {
                OptimizationDirection.Minimize => "MINIMIZE",
                OptimizationDirection.Maximize => "MAXIMIZE",
                OptimizationDirection.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizationDirection? ToEnum(string value)
        {
            return value switch
            {
                "MINIMIZE" => OptimizationDirection.Minimize,
                "MAXIMIZE" => OptimizationDirection.Maximize,
                "NONE" => OptimizationDirection.None,
                _ => null,
            };
        }
    }
}