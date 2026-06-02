
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatContextDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        CodeEvaluator,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Graphql,
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
        /// <summary>
        /// 
        /// </summary>
        WebAccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContextDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContextDiscriminatorType value)
        {
            return value switch
            {
                ChatContextDiscriminatorType.App => "app",
                ChatContextDiscriminatorType.CodeEvaluator => "code_evaluator",
                ChatContextDiscriminatorType.Dataset => "dataset",
                ChatContextDiscriminatorType.Graphql => "graphql",
                ChatContextDiscriminatorType.Playground => "playground",
                ChatContextDiscriminatorType.Project => "project",
                ChatContextDiscriminatorType.Span => "span",
                ChatContextDiscriminatorType.Trace => "trace",
                ChatContextDiscriminatorType.WebAccess => "web_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContextDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => ChatContextDiscriminatorType.App,
                "code_evaluator" => ChatContextDiscriminatorType.CodeEvaluator,
                "dataset" => ChatContextDiscriminatorType.Dataset,
                "graphql" => ChatContextDiscriminatorType.Graphql,
                "playground" => ChatContextDiscriminatorType.Playground,
                "project" => ChatContextDiscriminatorType.Project,
                "span" => ChatContextDiscriminatorType.Span,
                "trace" => ChatContextDiscriminatorType.Trace,
                "web_access" => ChatContextDiscriminatorType.WebAccess,
                _ => null,
            };
        }
    }
}