#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class CreateAnnotationConfigDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.CreateAnnotationConfigData>
    {
        /// <inheritdoc />
        public override global::Phoenix.CreateAnnotationConfigData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CreateAnnotationConfigDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CreateAnnotationConfigDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.CategoricalAnnotationConfigData? categorical = default;
            if (discriminator?.Type == global::Phoenix.CreateAnnotationConfigDataDiscriminatorType.Categorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CategoricalAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CategoricalAnnotationConfigData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CategoricalAnnotationConfigData)}");
                categorical = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.ContinuousAnnotationConfigData? continuous = default;
            if (discriminator?.Type == global::Phoenix.CreateAnnotationConfigDataDiscriminatorType.Continuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ContinuousAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ContinuousAnnotationConfigData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ContinuousAnnotationConfigData)}");
                continuous = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.FreeformAnnotationConfigData? freeform = default;
            if (discriminator?.Type == global::Phoenix.CreateAnnotationConfigDataDiscriminatorType.Freeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.FreeformAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.FreeformAnnotationConfigData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.FreeformAnnotationConfigData)}");
                freeform = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.CreateAnnotationConfigData(
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
            global::Phoenix.CreateAnnotationConfigData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCategorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CategoricalAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CategoricalAnnotationConfigData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.CategoricalAnnotationConfigData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Categorical!, typeInfo);
            }
            else if (value.IsContinuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ContinuousAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ContinuousAnnotationConfigData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ContinuousAnnotationConfigData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Continuous!, typeInfo);
            }
            else if (value.IsFreeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.FreeformAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.FreeformAnnotationConfigData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.FreeformAnnotationConfigData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Freeform!, typeInfo);
            }
        }
    }
}