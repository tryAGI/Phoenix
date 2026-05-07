#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ChatV2ChatV2PostRootJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ChatV2ChatV2PostRoot>
    {
        /// <inheritdoc />
        public override global::Phoenix.ChatV2ChatV2PostRoot Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatV2ChatV2PostRootDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatV2ChatV2PostRootDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatV2ChatV2PostRootDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.CustomProviderChatSearchParams? custom = default;
            if (discriminator?.ProviderType == global::Phoenix.ChatV2ChatV2PostRootDiscriminatorProviderType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CustomProviderChatSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CustomProviderChatSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CustomProviderChatSearchParams)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.BuiltInProviderChatSearchParams? builtin = default;
            if (discriminator?.ProviderType == global::Phoenix.ChatV2ChatV2PostRootDiscriminatorProviderType.Builtin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.BuiltInProviderChatSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.BuiltInProviderChatSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.BuiltInProviderChatSearchParams)}");
                builtin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ChatV2ChatV2PostRoot(
                discriminator?.ProviderType,
                custom,

                builtin
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ChatV2ChatV2PostRoot value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CustomProviderChatSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CustomProviderChatSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.CustomProviderChatSearchParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
            else if (value.IsBuiltin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.BuiltInProviderChatSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.BuiltInProviderChatSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.BuiltInProviderChatSearchParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Builtin!, typeInfo);
            }
        }
    }
}