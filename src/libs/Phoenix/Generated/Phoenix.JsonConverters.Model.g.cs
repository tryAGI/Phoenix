#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.Model>
    {
        /// <inheritdoc />
        public override global::Phoenix.Model Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatRegenerateMessageModelDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatRegenerateMessageModelDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatRegenerateMessageModelDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.CustomProviderModelSelection? custom = default;
            if (discriminator?.ProviderType == global::Phoenix.ChatRegenerateMessageModelDiscriminatorProviderType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CustomProviderModelSelection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CustomProviderModelSelection> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CustomProviderModelSelection)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.BuiltInProviderModelSelection? builtin = default;
            if (discriminator?.ProviderType == global::Phoenix.ChatRegenerateMessageModelDiscriminatorProviderType.Builtin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.BuiltInProviderModelSelection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.BuiltInProviderModelSelection> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.BuiltInProviderModelSelection)}");
                builtin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.Model(
                discriminator?.ProviderType,
                custom,

                builtin
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.Model value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CustomProviderModelSelection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CustomProviderModelSelection?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.CustomProviderModelSelection).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
            else if (value.IsBuiltin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.BuiltInProviderModelSelection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.BuiltInProviderModelSelection?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.BuiltInProviderModelSelection).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Builtin!, typeInfo);
            }
        }
    }
}