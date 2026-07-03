
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        Continuous,
        /// <summary>
        /// 
        /// </summary>
        Freeform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType value)
        {
            return value switch
            {
                GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Categorical => "CATEGORICAL",
                GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Continuous => "CONTINUOUS",
                GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Categorical,
                "CONTINUOUS" => GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Continuous,
                "FREEFORM" => GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}