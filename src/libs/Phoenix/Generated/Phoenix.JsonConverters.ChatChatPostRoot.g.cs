#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ChatChatPostRootJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ChatChatPostRoot>
    {
        /// <inheritdoc />
        public override global::Phoenix.ChatChatPostRoot Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatChatPostRootDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatChatPostRootDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatChatPostRootDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.CustomProviderChatSearchParams? custom = default;
            if (discriminator?.ProviderType == global::Phoenix.ChatChatPostRootDiscriminatorProviderType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CustomProviderChatSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CustomProviderChatSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CustomProviderChatSearchParams)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.BuiltInProviderChatSearchParams? builtin = default;
            if (discriminator?.ProviderType == global::Phoenix.ChatChatPostRootDiscriminatorProviderType.Builtin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.BuiltInProviderChatSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.BuiltInProviderChatSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.BuiltInProviderChatSearchParams)}");
                builtin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ChatChatPostRoot(
                discriminator?.ProviderType,
                custom,

                builtin
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ChatChatPostRoot value,
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