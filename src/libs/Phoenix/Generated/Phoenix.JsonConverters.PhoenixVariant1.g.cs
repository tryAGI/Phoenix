#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class PhoenixVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.PhoenixVariant1>
    {
        /// <inheritdoc />
        public override global::Phoenix.PhoenixVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.MessageMetadataPhoenixVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.MessageMetadataPhoenixVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.MessageMetadataPhoenixVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.PhoenixAssistantMessageMetadata? assistant = default;
            if (discriminator?.Type == global::Phoenix.MessageMetadataPhoenixVariant1DiscriminatorType.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PhoenixAssistantMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PhoenixAssistantMessageMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PhoenixAssistantMessageMetadata)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PhoenixUserMessageMetadata? user = default;
            if (discriminator?.Type == global::Phoenix.MessageMetadataPhoenixVariant1DiscriminatorType.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PhoenixUserMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PhoenixUserMessageMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PhoenixUserMessageMetadata)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.PhoenixVariant1(
                discriminator?.Type,
                assistant,

                user
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.PhoenixVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PhoenixAssistantMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PhoenixAssistantMessageMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PhoenixAssistantMessageMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant!, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PhoenixUserMessageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PhoenixUserMessageMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PhoenixUserMessageMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User!, typeInfo);
            }
        }
    }
}