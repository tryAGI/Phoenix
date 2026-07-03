
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType
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
    public static class SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType value)
        {
            return value switch
            {
                SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Categorical => "CATEGORICAL",
                SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Continuous => "CONTINUOUS",
                SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Categorical,
                "CONTINUOUS" => SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Continuous,
                "FREEFORM" => SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}