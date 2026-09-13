
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRunRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRunResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRunResponseBodyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DatasetExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DatasetExampleSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ExperimentEvaluationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ExperimentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ExperimentTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetExperimentResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetIncompleteEvaluationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.IncompleteExperimentEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetIncompleteExperimentRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.IncompleteExperimentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListExperimentRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListExperimentTagsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ExperimentTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListExperimentsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetExperimentTagRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetExperimentTagResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateExperimentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateExperimentResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind), TypeInfoPropertyName = "UpsertExperimentEvaluationRequestBodyAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationResponseBodyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind?), TypeInfoPropertyName = "NullableUpsertExperimentEvaluationRequestBodyAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ExperimentTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AnyOf<string, int?>>))]
    internal sealed partial class ExperimentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExperimentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ExperimentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ExperimentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind)

                    || typeToConvert == typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind))
                {
                    return new global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind?))
                {
                    return new global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindNullableJsonConverter();
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
                    0 => new ExperimentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}