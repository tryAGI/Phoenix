
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum SummarizeRequestModelDiscriminatorProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Builtin,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizeRequestModelDiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizeRequestModelDiscriminatorProviderType value)
        {
            return value switch
            {
                SummarizeRequestModelDiscriminatorProviderType.Builtin => "builtin",
                SummarizeRequestModelDiscriminatorProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizeRequestModelDiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => SummarizeRequestModelDiscriminatorProviderType.Builtin,
                "custom" => SummarizeRequestModelDiscriminatorProviderType.Custom,
                _ => null,
            };
        }
    }
}