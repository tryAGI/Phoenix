
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: responses
    /// </summary>
    public enum BuiltInProviderModelSelectionOpenaiApiType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuiltInProviderModelSelectionOpenaiApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuiltInProviderModelSelectionOpenaiApiType value)
        {
            return value switch
            {
                BuiltInProviderModelSelectionOpenaiApiType.ChatCompletions => "chat_completions",
                BuiltInProviderModelSelectionOpenaiApiType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuiltInProviderModelSelectionOpenaiApiType? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => BuiltInProviderModelSelectionOpenaiApiType.ChatCompletions,
                "responses" => BuiltInProviderModelSelectionOpenaiApiType.Responses,
                _ => null,
            };
        }
    }
}