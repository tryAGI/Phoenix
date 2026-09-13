
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data), TypeInfoPropertyName = "Data2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContinuousAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.FreeformAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OptimizationDirection), TypeInfoPropertyName = "OptimizationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.CategoricalAnnotationValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContinuousAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigData), TypeInfoPropertyName = "CreateAnnotationConfigData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.FreeformAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType), TypeInfoPropertyName = "CreateAnnotationConfigDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data2), TypeInfoPropertyName = "Data22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "CreateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data4), TypeInfoPropertyName = "Data42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "DeleteAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data5), TypeInfoPropertyName = "Data52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "GetAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem), TypeInfoPropertyName = "DataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType), TypeInfoPropertyName = "GetAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType), TypeInfoPropertyName = "GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem4), TypeInfoPropertyName = "DataItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType), TypeInfoPropertyName = "SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data7), TypeInfoPropertyName = "Data72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "UpdateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data?), TypeInfoPropertyName = "NullableData2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableAssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OptimizationDirection?), TypeInfoPropertyName = "NullableOptimizationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigData?), TypeInfoPropertyName = "NullableCreateAnnotationConfigData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAnnotationConfigDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data2?), TypeInfoPropertyName = "NullableData22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data4?), TypeInfoPropertyName = "NullableData42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableDeleteAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data5?), TypeInfoPropertyName = "NullableData52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableGetAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem?), TypeInfoPropertyName = "NullableDataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem2?), TypeInfoPropertyName = "NullableDataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem4?), TypeInfoPropertyName = "NullableDataItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableSetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data7?), TypeInfoPropertyName = "NullableData72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.CategoricalAnnotationValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AnyOf<string, int?>>))]
    internal sealed partial class AnnotationConfigsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationConfigsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnnotationConfigsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnnotationConfigsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Phoenix.JsonConverters.DataJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateAnnotationConfigDataJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data4JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data5JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItemJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItem4JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data7JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Phoenix.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.OptimizationDirection)

                    || typeToConvert == typeof(global::Phoenix.OptimizationDirection?)

                    || typeToConvert == typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OptimizationDirection))
                {
                    return new global::Phoenix.JsonConverters.OptimizationDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OptimizationDirection?))
                {
                    return new global::Phoenix.JsonConverters.OptimizationDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AnnotationConfigsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}