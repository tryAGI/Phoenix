
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        Xai,
        /// <summary>
        /// 
        /// </summary>
        Ollama,
        /// <summary>
        /// 
        /// </summary>
        Aws,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Fireworks,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Moonshot,
        /// <summary>
        /// 
        /// </summary>
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        Together,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelProvider value)
        {
            return value switch
            {
                ModelProvider.Openai => "OPENAI",
                ModelProvider.AzureOpenai => "AZURE_OPENAI",
                ModelProvider.Anthropic => "ANTHROPIC",
                ModelProvider.Google => "GOOGLE",
                ModelProvider.Deepseek => "DEEPSEEK",
                ModelProvider.Xai => "XAI",
                ModelProvider.Ollama => "OLLAMA",
                ModelProvider.Aws => "AWS",
                ModelProvider.Cerebras => "CEREBRAS",
                ModelProvider.Fireworks => "FIREWORKS",
                ModelProvider.Groq => "GROQ",
                ModelProvider.Moonshot => "MOONSHOT",
                ModelProvider.Perplexity => "PERPLEXITY",
                ModelProvider.Together => "TOGETHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "OPENAI" => ModelProvider.Openai,
                "AZURE_OPENAI" => ModelProvider.AzureOpenai,
                "ANTHROPIC" => ModelProvider.Anthropic,
                "GOOGLE" => ModelProvider.Google,
                "DEEPSEEK" => ModelProvider.Deepseek,
                "XAI" => ModelProvider.Xai,
                "OLLAMA" => ModelProvider.Ollama,
                "AWS" => ModelProvider.Aws,
                "CEREBRAS" => ModelProvider.Cerebras,
                "FIREWORKS" => ModelProvider.Fireworks,
                "GROQ" => ModelProvider.Groq,
                "MOONSHOT" => ModelProvider.Moonshot,
                "PERPLEXITY" => ModelProvider.Perplexity,
                "TOGETHER" => ModelProvider.Together,
                _ => null,
            };
        }
    }
}