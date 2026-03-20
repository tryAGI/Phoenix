#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ThinkingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.Thinking>
    {
        /// <inheritdoc />
        public override global::Phoenix.Thinking Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.PromptAnthropicThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAnthropicThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAnthropicThinkingConfigDisabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptAnthropicThinkingConfigDisabled)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptAnthropicThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Enabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAnthropicThinkingConfigEnabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptAnthropicThinkingConfigEnabled)}");
                enabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.Thinking(
                discriminator?.Type,
                disabled,

                enabled
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.Thinking value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAnthropicThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAnthropicThinkingConfigDisabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptAnthropicThinkingConfigDisabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeInfo);
            }
            else if (value.IsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptAnthropicThinkingConfigEnabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled, typeInfo);
            }
        }
    }
}