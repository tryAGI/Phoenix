
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionRequestMessageRole), TypeInfoPropertyName = "ChatCompletionRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionTextPart>>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionTextPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionTextPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionTextPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateChatCompletionRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatCompletionRequestMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionTextPart>>?), TypeInfoPropertyName = "NullableAnyOfStringIListChatCompletionTextPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<global::Phoenix.ChatCompletionTextPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ChatCompletionTextPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    internal sealed partial class ChatCompletionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatCompletionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatCompletionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionTextPart>>());
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
                    typeToConvert == typeof(global::Phoenix.ChatCompletionRequestMessageRole)

                    || typeToConvert == typeof(global::Phoenix.ChatCompletionRequestMessageRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Phoenix.ChatCompletionRequestMessageRole))
                {
                    return new global::Phoenix.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.ChatCompletionRequestMessageRole?))
                {
                    return new global::Phoenix.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter();
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
                    0 => new ChatCompletionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}