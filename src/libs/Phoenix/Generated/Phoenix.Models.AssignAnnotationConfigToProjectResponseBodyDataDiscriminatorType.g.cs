
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType
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
    public static class AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType value)
        {
            return value switch
            {
                AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType.Categorical => "CATEGORICAL",
                AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType.Continuous => "CONTINUOUS",
                AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType.Categorical,
                "CONTINUOUS" => AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType.Continuous,
                "FREEFORM" => AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}