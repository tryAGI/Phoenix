
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubmitMessageContextDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Playground,
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
    public static class SubmitMessageContextDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitMessageContextDiscriminatorType value)
        {
            return value switch
            {
                SubmitMessageContextDiscriminatorType.App => "app",
                SubmitMessageContextDiscriminatorType.Playground => "playground",
                SubmitMessageContextDiscriminatorType.Project => "project",
                SubmitMessageContextDiscriminatorType.Span => "span",
                SubmitMessageContextDiscriminatorType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitMessageContextDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => SubmitMessageContextDiscriminatorType.App,
                "playground" => SubmitMessageContextDiscriminatorType.Playground,
                "project" => SubmitMessageContextDiscriminatorType.Project,
                "span" => SubmitMessageContextDiscriminatorType.Span,
                "trace" => SubmitMessageContextDiscriminatorType.Trace,
                _ => null,
            };
        }
    }
}