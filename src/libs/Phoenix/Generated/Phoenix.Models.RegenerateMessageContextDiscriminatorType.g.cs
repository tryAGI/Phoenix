
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegenerateMessageContextDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegenerateMessageContextDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegenerateMessageContextDiscriminatorType value)
        {
            return value switch
            {
                RegenerateMessageContextDiscriminatorType.App => "app",
                RegenerateMessageContextDiscriminatorType.Project => "project",
                RegenerateMessageContextDiscriminatorType.Span => "span",
                RegenerateMessageContextDiscriminatorType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegenerateMessageContextDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => RegenerateMessageContextDiscriminatorType.App,
                "project" => RegenerateMessageContextDiscriminatorType.Project,
                "span" => RegenerateMessageContextDiscriminatorType.Span,
                "trace" => RegenerateMessageContextDiscriminatorType.Trace,
                _ => null,
            };
        }
    }
}