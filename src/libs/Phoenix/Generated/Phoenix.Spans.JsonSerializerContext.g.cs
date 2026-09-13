
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpanDocumentsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanDocumentAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanDocumentAnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpanDocumentsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.InsertedSpanDocumentAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InsertedSpanDocumentAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpansRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.InsertedSpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InsertedSpanAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpanNoteRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanNoteData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpanNoteResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpansRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Span))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpAnyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpArrayValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<double?, global::Phoenix.OtlpDoubleValue?, string, object>), TypeInfoPropertyName = "AnyOfDoubleOtlpDoubleValueStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpDoubleValue), TypeInfoPropertyName = "OtlpDoubleValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpAnyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpKeyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<long?, string, object>), TypeInfoPropertyName = "AnyOfInt64StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpKind), TypeInfoPropertyName = "OtlpKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.OtlpKind?, int?, object>), TypeInfoPropertyName = "AnyOfOtlpKindInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpSpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind), TypeInfoPropertyName = "SpanAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind), TypeInfoPropertyName = "SpanDocumentAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<double?, global::Phoenix.OtlpDoubleValue?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleOtlpDoubleValueStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpDoubleValue?), TypeInfoPropertyName = "NullableOtlpDoubleValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<long?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt64StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpKind?), TypeInfoPropertyName = "NullableOtlpKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.OtlpKind?, int?, object>?), TypeInfoPropertyName = "NullableAnyOfOtlpKindInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind?), TypeInfoPropertyName = "NullableSpanAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind?), TypeInfoPropertyName = "NullableSpanDocumentAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanDocumentAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSpanDocumentAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpAnyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AnyOf<string, int?>>))]
    internal sealed partial class SpansSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpansSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SpansSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SpansSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<double?, global::Phoenix.OtlpDoubleValue?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.OtlpKind?, int?, object>());
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
                    typeToConvert == typeof(global::Phoenix.OtlpDoubleValue)

                    || typeToConvert == typeof(global::Phoenix.OtlpDoubleValue?)

                    || typeToConvert == typeof(global::Phoenix.OtlpKind)

                    || typeToConvert == typeof(global::Phoenix.OtlpKind?)

                    || typeToConvert == typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind?)

                    || typeToConvert == typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Phoenix.OtlpDoubleValue))
                {
                    return new global::Phoenix.JsonConverters.OtlpDoubleValueJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OtlpDoubleValue?))
                {
                    return new global::Phoenix.JsonConverters.OtlpDoubleValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OtlpKind))
                {
                    return new global::Phoenix.JsonConverters.OtlpKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OtlpKind?))
                {
                    return new global::Phoenix.JsonConverters.OtlpKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindNullableJsonConverter();
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
                    0 => new SpansSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}