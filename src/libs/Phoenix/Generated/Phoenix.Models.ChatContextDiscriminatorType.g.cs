
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
        LlmEvaluator,
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
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        PromptVersion,
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
        Subagents,
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
                ChatContextDiscriminatorType.LlmEvaluator => "llm_evaluator",
                ChatContextDiscriminatorType.Playground => "playground",
                ChatContextDiscriminatorType.Project => "project",
                ChatContextDiscriminatorType.Prompt => "prompt",
                ChatContextDiscriminatorType.PromptVersion => "prompt_version",
                ChatContextDiscriminatorType.Session => "session",
                ChatContextDiscriminatorType.Span => "span",
                ChatContextDiscriminatorType.Subagents => "subagents",
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
                "llm_evaluator" => ChatContextDiscriminatorType.LlmEvaluator,
                "playground" => ChatContextDiscriminatorType.Playground,
                "project" => ChatContextDiscriminatorType.Project,
                "prompt" => ChatContextDiscriminatorType.Prompt,
                "prompt_version" => ChatContextDiscriminatorType.PromptVersion,
                "session" => ChatContextDiscriminatorType.Session,
                "span" => ChatContextDiscriminatorType.Span,
                "subagents" => ChatContextDiscriminatorType.Subagents,
                "trace" => ChatContextDiscriminatorType.Trace,
                "web_access" => ChatContextDiscriminatorType.WebAccess,
                _ => null,
            };
        }
    }
}