#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class InvocationParametersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.InvocationParameters>
    {
        /// <inheritdoc />
        public override global::Phoenix.InvocationParameters Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptVersionInvocationParametersDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptVersionInvocationParametersDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.PromptOpenAIInvocationParameters? openai = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptOpenAIInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptOpenAIInvocationParameters)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptAzureOpenAIInvocationParameters? azureOpenai = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.AzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAzureOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAzureOpenAIInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptAzureOpenAIInvocationParameters)}");
                azureOpenai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptAnthropicInvocationParameters? anthropic = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAnthropicInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAnthropicInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptAnthropicInvocationParameters)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptGoogleInvocationParameters? google = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Google)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptGoogleInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptGoogleInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptGoogleInvocationParameters)}");
                google = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptDeepSeekInvocationParameters? deepseek = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Deepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptDeepSeekInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptDeepSeekInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptDeepSeekInvocationParameters)}");
                deepseek = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptXAIInvocationParameters? xai = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptXAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptXAIInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptXAIInvocationParameters)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptOllamaInvocationParameters? ollama = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Ollama)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptOllamaInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptOllamaInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptOllamaInvocationParameters)}");
                ollama = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptAwsInvocationParameters? aws = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAwsInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAwsInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptAwsInvocationParameters)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptCerebrasInvocationParameters? cerebras = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Cerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptCerebrasInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptCerebrasInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptCerebrasInvocationParameters)}");
                cerebras = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptFireworksInvocationParameters? fireworks = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Fireworks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptFireworksInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptFireworksInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptFireworksInvocationParameters)}");
                fireworks = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptGroqInvocationParameters? groq = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Groq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptGroqInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptGroqInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptGroqInvocationParameters)}");
                groq = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptMoonshotInvocationParameters? moonshot = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Moonshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptMoonshotInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptMoonshotInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptMoonshotInvocationParameters)}");
                moonshot = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptPerplexityInvocationParameters? perplexity = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Perplexity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptPerplexityInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptPerplexityInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptPerplexityInvocationParameters)}");
                perplexity = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptTogetherInvocationParameters? together = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionInvocationParametersDiscriminatorType.Together)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptTogetherInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptTogetherInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptTogetherInvocationParameters)}");
                together = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.InvocationParameters(
                discriminator?.Type,
                openai,

                azureOpenai,

                anthropic,

                google,

                deepseek,

                xai,

                ollama,

                aws,

                cerebras,

                fireworks,

                groq,

                moonshot,

                perplexity,

                together
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.InvocationParameters value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptOpenAIInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptOpenAIInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai!, typeInfo);
            }
            else if (value.IsAzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAzureOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAzureOpenAIInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptAzureOpenAIInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureOpenai!, typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAnthropicInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAnthropicInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptAnthropicInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic!, typeInfo);
            }
            else if (value.IsGoogle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptGoogleInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptGoogleInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptGoogleInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google!, typeInfo);
            }
            else if (value.IsDeepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptDeepSeekInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptDeepSeekInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptDeepSeekInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepseek!, typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptXAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptXAIInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptXAIInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai!, typeInfo);
            }
            else if (value.IsOllama)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptOllamaInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptOllamaInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptOllamaInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ollama!, typeInfo);
            }
            else if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAwsInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAwsInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptAwsInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aws!, typeInfo);
            }
            else if (value.IsCerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptCerebrasInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptCerebrasInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptCerebrasInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cerebras!, typeInfo);
            }
            else if (value.IsFireworks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptFireworksInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptFireworksInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptFireworksInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fireworks!, typeInfo);
            }
            else if (value.IsGroq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptGroqInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptGroqInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptGroqInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq!, typeInfo);
            }
            else if (value.IsMoonshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptMoonshotInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptMoonshotInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptMoonshotInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Moonshot!, typeInfo);
            }
            else if (value.IsPerplexity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptPerplexityInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptPerplexityInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptPerplexityInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Perplexity!, typeInfo);
            }
            else if (value.IsTogether)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptTogetherInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptTogetherInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptTogetherInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Together!, typeInfo);
            }
        }
    }
}