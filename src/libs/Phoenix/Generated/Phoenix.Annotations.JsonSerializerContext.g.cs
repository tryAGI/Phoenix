
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationSource), TypeInfoPropertyName = "SessionAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationAnnotatorKind), TypeInfoPropertyName = "SessionAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationSource), TypeInfoPropertyName = "SpanAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationAnnotatorKind), TypeInfoPropertyName = "SpanAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationSource), TypeInfoPropertyName = "TraceAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationAnnotatorKind), TypeInfoPropertyName = "TraceAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.TraceAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSpanAnnotationsAnnotatorKind), TypeInfoPropertyName = "DeleteSpanAnnotationsAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteTraceAnnotationsAnnotatorKind), TypeInfoPropertyName = "DeleteTraceAnnotationsAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind), TypeInfoPropertyName = "DeleteSessionAnnotationsAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationSource?), TypeInfoPropertyName = "NullableSessionAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationAnnotatorKind?), TypeInfoPropertyName = "NullableSessionAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationSource?), TypeInfoPropertyName = "NullableSpanAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationAnnotatorKind?), TypeInfoPropertyName = "NullableSpanAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationSource?), TypeInfoPropertyName = "NullableTraceAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationAnnotatorKind?), TypeInfoPropertyName = "NullableTraceAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSpanAnnotationsAnnotatorKind?), TypeInfoPropertyName = "NullableDeleteSpanAnnotationsAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteTraceAnnotationsAnnotatorKind?), TypeInfoPropertyName = "NullableDeleteTraceAnnotationsAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind?), TypeInfoPropertyName = "NullableDeleteSessionAnnotationsAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceAnnotation>))]
    internal sealed partial class AnnotationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnnotationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnnotationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Phoenix.SessionAnnotationSource)

                    || typeToConvert == typeof(global::Phoenix.SessionAnnotationSource?)

                    || typeToConvert == typeof(global::Phoenix.SessionAnnotationAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.SessionAnnotationAnnotatorKind?)

                    || typeToConvert == typeof(global::Phoenix.SpanAnnotationSource)

                    || typeToConvert == typeof(global::Phoenix.SpanAnnotationSource?)

                    || typeToConvert == typeof(global::Phoenix.SpanAnnotationAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.SpanAnnotationAnnotatorKind?)

                    || typeToConvert == typeof(global::Phoenix.TraceAnnotationSource)

                    || typeToConvert == typeof(global::Phoenix.TraceAnnotationSource?)

                    || typeToConvert == typeof(global::Phoenix.TraceAnnotationAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.TraceAnnotationAnnotatorKind?)

                    || typeToConvert == typeof(global::Phoenix.DeleteSpanAnnotationsAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.DeleteSpanAnnotationsAnnotatorKind?)

                    || typeToConvert == typeof(global::Phoenix.DeleteTraceAnnotationsAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.DeleteTraceAnnotationsAnnotatorKind?)

                    || typeToConvert == typeof(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Phoenix.SessionAnnotationSource))
                {
                    return new global::Phoenix.JsonConverters.SessionAnnotationSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SessionAnnotationSource?))
                {
                    return new global::Phoenix.JsonConverters.SessionAnnotationSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SessionAnnotationAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SessionAnnotationAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanAnnotationSource))
                {
                    return new global::Phoenix.JsonConverters.SpanAnnotationSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanAnnotationSource?))
                {
                    return new global::Phoenix.JsonConverters.SpanAnnotationSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanAnnotationAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.SpanAnnotationAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.TraceAnnotationSource))
                {
                    return new global::Phoenix.JsonConverters.TraceAnnotationSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.TraceAnnotationSource?))
                {
                    return new global::Phoenix.JsonConverters.TraceAnnotationSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.TraceAnnotationAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.TraceAnnotationAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteSpanAnnotationsAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteSpanAnnotationsAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteTraceAnnotationsAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteTraceAnnotationsAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKindNullableJsonConverter();
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
                    0 => new AnnotationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}