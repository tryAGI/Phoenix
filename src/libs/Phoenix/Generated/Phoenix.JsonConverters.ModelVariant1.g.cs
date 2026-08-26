#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ModelVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ModelVariant1>
    {
        /// <inheritdoc />
        public override global::Phoenix.ModelVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundInstanceUIContextModelVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundInstanceUIContextModelVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PlaygroundInstanceUIContextModelVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.PlaygroundBuiltinModelUIContext? builtin = default;
            if (discriminator?.Type == global::Phoenix.PlaygroundInstanceUIContextModelVariant1DiscriminatorType.Builtin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundBuiltinModelUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundBuiltinModelUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PlaygroundBuiltinModelUIContext)}");
                builtin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PlaygroundCustomProviderModelUIContext? custom = default;
            if (discriminator?.Type == global::Phoenix.PlaygroundInstanceUIContextModelVariant1DiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundCustomProviderModelUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundCustomProviderModelUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PlaygroundCustomProviderModelUIContext)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ModelVariant1(
                discriminator?.Type,
                builtin,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ModelVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBuiltin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundBuiltinModelUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundBuiltinModelUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PlaygroundBuiltinModelUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Builtin!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundCustomProviderModelUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundCustomProviderModelUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PlaygroundCustomProviderModelUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}