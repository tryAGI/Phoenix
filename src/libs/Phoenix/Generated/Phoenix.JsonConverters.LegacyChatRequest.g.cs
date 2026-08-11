#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class LegacyChatRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.LegacyChatRequest>
    {
        /// <inheritdoc />
        public override global::Phoenix.LegacyChatRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LegacyChatRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LegacyChatRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LegacyChatRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.LegacyChatSubmitMessage? submitMessage = default;
            if (discriminator?.Trigger == global::Phoenix.LegacyChatRequestDiscriminatorTrigger.SubmitMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LegacyChatSubmitMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LegacyChatSubmitMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LegacyChatSubmitMessage)}");
                submitMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.LegacyChatRegenerateMessage? regenerateMessage = default;
            if (discriminator?.Trigger == global::Phoenix.LegacyChatRequestDiscriminatorTrigger.RegenerateMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LegacyChatRegenerateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LegacyChatRegenerateMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LegacyChatRegenerateMessage)}");
                regenerateMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.LegacyChatRequest(
                discriminator?.Trigger,
                submitMessage,

                regenerateMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.LegacyChatRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSubmitMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LegacyChatSubmitMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LegacyChatSubmitMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LegacyChatSubmitMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubmitMessage!, typeInfo);
            }
            else if (value.IsRegenerateMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LegacyChatRegenerateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LegacyChatRegenerateMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LegacyChatRegenerateMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RegenerateMessage!, typeInfo);
            }
        }
    }
}