#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ResponseFormatVariant1>
    {
        /// <inheritdoc />
        public override global::Phoenix.ResponseFormatVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptVersionResponseFormatVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptVersionResponseFormatVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptVersionResponseFormatVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.PromptResponseFormatJSONSchema? jsonSchema = default;
            if (discriminator?.Type == global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptResponseFormatJSONSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptResponseFormatJSONSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptResponseFormatJSONSchema)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ResponseFormatVariant1(
                discriminator?.Type,
                jsonSchema
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ResponseFormatVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptResponseFormatJSONSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptResponseFormatJSONSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptResponseFormatJSONSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeInfo);
            }
        }
    }
}