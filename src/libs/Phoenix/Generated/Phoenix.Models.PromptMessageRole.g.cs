
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptMessageRole value)
        {
            return value switch
            {
                PromptMessageRole.User => "user",
                PromptMessageRole.Assistant => "assistant",
                PromptMessageRole.Model => "model",
                PromptMessageRole.Ai => "ai",
                PromptMessageRole.Tool => "tool",
                PromptMessageRole.System => "system",
                PromptMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => PromptMessageRole.User,
                "assistant" => PromptMessageRole.Assistant,
                "model" => PromptMessageRole.Model,
                "ai" => PromptMessageRole.Ai,
                "tool" => PromptMessageRole.Tool,
                "system" => PromptMessageRole.System,
                "developer" => PromptMessageRole.Developer,
                _ => null,
            };
        }
    }
}