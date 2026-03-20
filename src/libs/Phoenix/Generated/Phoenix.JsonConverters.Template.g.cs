#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class TemplateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.Template>
    {
        /// <inheritdoc />
        public override global::Phoenix.Template Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptVersionTemplateDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptVersionTemplateDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptVersionTemplateDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.PromptChatTemplate? chat = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionTemplateDiscriminatorType.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptChatTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptChatTemplate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptChatTemplate)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptStringTemplate? @string = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionTemplateDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptStringTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptStringTemplate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptStringTemplate)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.Template(
                discriminator?.Type,
                chat,

                @string
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.Template value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptChatTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptChatTemplate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptChatTemplate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeInfo);
            }
            else if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptStringTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptStringTemplate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptStringTemplate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeInfo);
            }
        }
    }
}