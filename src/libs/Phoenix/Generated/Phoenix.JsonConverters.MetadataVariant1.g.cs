#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class MetadataVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.MetadataVariant1>
    {
        /// <inheritdoc />
        public override global::Phoenix.MetadataVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PhoenixUIMessageMetadataVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PhoenixUIMessageMetadataVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PhoenixUIMessageMetadataVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.AssistantMessageMetadata? assistant = default;
            if (discriminator?.Type == global::Phoenix.PhoenixUIMessageMetadataVariant1DiscriminatorType.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AssistantMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AssistantMessageMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.AssistantMessageMetadata)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.UserMessageMetadata? user = default;
            if (discriminator?.Type == global::Phoenix.PhoenixUIMessageMetadataVariant1DiscriminatorType.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.UserMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.UserMessageMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.UserMessageMetadata)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.MetadataVariant1(
                discriminator?.Type,
                assistant,

                user
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.MetadataVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AssistantMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AssistantMessageMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.AssistantMessageMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant!, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.UserMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.UserMessageMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.UserMessageMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User!, typeInfo);
            }
        }
    }
}