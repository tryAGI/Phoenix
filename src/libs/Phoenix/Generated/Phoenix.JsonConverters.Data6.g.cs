#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class Data6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.Data6>
    {
        /// <inheritdoc />
        public override global::Phoenix.Data6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.CategoricalAnnotationConfig? categorical = default;
            if (discriminator?.Type == global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Categorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CategoricalAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CategoricalAnnotationConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CategoricalAnnotationConfig)}");
                categorical = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.ContinuousAnnotationConfig? continuous = default;
            if (discriminator?.Type == global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Continuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ContinuousAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ContinuousAnnotationConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ContinuousAnnotationConfig)}");
                continuous = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.FreeformAnnotationConfig? freeform = default;
            if (discriminator?.Type == global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Freeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.FreeformAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.FreeformAnnotationConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.FreeformAnnotationConfig)}");
                freeform = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.Data6(
                discriminator?.Type,
                categorical,

                continuous,

                freeform
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.Data6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCategorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CategoricalAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CategoricalAnnotationConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.CategoricalAnnotationConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Categorical, typeInfo);
            }
            else if (value.IsContinuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ContinuousAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ContinuousAnnotationConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ContinuousAnnotationConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Continuous, typeInfo);
            }
            else if (value.IsFreeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.FreeformAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.FreeformAnnotationConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.FreeformAnnotationConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Freeform, typeInfo);
            }
        }
    }
}