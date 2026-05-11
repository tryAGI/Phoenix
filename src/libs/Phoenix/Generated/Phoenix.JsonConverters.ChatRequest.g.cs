#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ChatRequest>
    {
        /// <inheritdoc />
        public override global::Phoenix.ChatRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.ChatSubmitMessage? submitMessage = default;
            if (discriminator?.Trigger == global::Phoenix.ChatRequestDiscriminatorTrigger.SubmitMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatSubmitMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatSubmitMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatSubmitMessage)}");
                submitMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.ChatRegenerateMessage? regenerateMessage = default;
            if (discriminator?.Trigger == global::Phoenix.ChatRequestDiscriminatorTrigger.RegenerateMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatRegenerateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatRegenerateMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatRegenerateMessage)}");
                regenerateMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ChatRequest(
                discriminator?.Trigger,
                submitMessage,

                regenerateMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ChatRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSubmitMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatSubmitMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatSubmitMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ChatSubmitMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubmitMessage!, typeInfo);
            }
            else if (value.IsRegenerateMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatRegenerateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatRegenerateMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ChatRegenerateMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RegenerateMessage!, typeInfo);
            }
        }
    }
}