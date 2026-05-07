#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ChatV2ChatV2PostRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ChatV2ChatV2PostRequest>
    {
        /// <inheritdoc />
        public override global::Phoenix.ChatV2ChatV2PostRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatV2ChatV2PostRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatV2ChatV2PostRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatV2ChatV2PostRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.SubmitMessage? submitMessage = default;
            if (discriminator?.Trigger == global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger.SubmitMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SubmitMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SubmitMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.SubmitMessage)}");
                submitMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.RegenerateMessage? regenerateMessage = default;
            if (discriminator?.Trigger == global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger.RegenerateMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.RegenerateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.RegenerateMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.RegenerateMessage)}");
                regenerateMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ChatV2ChatV2PostRequest(
                discriminator?.Trigger,
                submitMessage,

                regenerateMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ChatV2ChatV2PostRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSubmitMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SubmitMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SubmitMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.SubmitMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubmitMessage!, typeInfo);
            }
            else if (value.IsRegenerateMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.RegenerateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.RegenerateMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.RegenerateMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RegenerateMessage!, typeInfo);
            }
        }
    }
}