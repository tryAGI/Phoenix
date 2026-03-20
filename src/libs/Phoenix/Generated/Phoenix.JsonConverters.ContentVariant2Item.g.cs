#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::Phoenix.ContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptMessageContentVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.TextContentPart? text = default;
            if (discriminator?.Type == global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.TextContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.TextContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.TextContentPart)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.ToolCallContentPart? toolCall = default;
            if (discriminator?.Type == global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType.ToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ToolCallContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ToolCallContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ToolCallContentPart)}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.ToolResultContentPart? toolResult = default;
            if (discriminator?.Type == global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType.ToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ToolResultContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ToolResultContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ToolResultContentPart)}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ContentVariant2Item(
                discriminator?.Type,
                text,

                toolCall,

                toolResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ContentVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.TextContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.TextContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.TextContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ToolCallContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ToolCallContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ToolCallContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall, typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ToolResultContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ToolResultContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ToolResultContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeInfo);
            }
        }
    }
}