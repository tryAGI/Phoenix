#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ChatContextJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ChatContext>
    {
        /// <inheritdoc />
        public override global::Phoenix.ChatContext Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ChatContextDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ChatContextDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ChatContextDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.AppContext? app = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.App)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AppContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AppContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.AppContext)}");
                app = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.ProjectContext? project = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Project)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ProjectContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ProjectContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ProjectContext)}");
                project = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.TraceContext? trace = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Trace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.TraceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.TraceContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.TraceContext)}");
                trace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.AgentSpanContext? span = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Span)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AgentSpanContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AgentSpanContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.AgentSpanContext)}");
                span = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PlaygroundContext? playground = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Playground)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PlaygroundContext)}");
                playground = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.CodeEvaluatorContext? codeEvaluator = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.CodeEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CodeEvaluatorContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CodeEvaluatorContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CodeEvaluatorContext)}");
                codeEvaluator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.LlmEvaluatorContext? llmEvaluator = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.LlmEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LlmEvaluatorContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LlmEvaluatorContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LlmEvaluatorContext)}");
                llmEvaluator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.DatasetContext? dataset = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Dataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.DatasetContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.DatasetContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.DatasetContext)}");
                dataset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.GraphQLContext? graphql = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Graphql)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.GraphQLContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.GraphQLContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.GraphQLContext)}");
                graphql = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.WebAccessContext? webAccess = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.WebAccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.WebAccessContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.WebAccessContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.WebAccessContext)}");
                webAccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ChatContext(
                discriminator?.Type,
                app,

                project,

                trace,

                span,

                playground,

                codeEvaluator,

                llmEvaluator,

                dataset,

                graphql,

                webAccess
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ChatContext value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AppContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AppContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.AppContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.App!, typeInfo);
            }
            else if (value.IsProject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ProjectContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ProjectContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ProjectContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Project!, typeInfo);
            }
            else if (value.IsTrace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.TraceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.TraceContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.TraceContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trace!, typeInfo);
            }
            else if (value.IsSpan)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AgentSpanContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AgentSpanContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.AgentSpanContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Span!, typeInfo);
            }
            else if (value.IsPlayground)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PlaygroundContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Playground!, typeInfo);
            }
            else if (value.IsCodeEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CodeEvaluatorContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CodeEvaluatorContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.CodeEvaluatorContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeEvaluator!, typeInfo);
            }
            else if (value.IsLlmEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LlmEvaluatorContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LlmEvaluatorContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LlmEvaluatorContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LlmEvaluator!, typeInfo);
            }
            else if (value.IsDataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.DatasetContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.DatasetContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.DatasetContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dataset!, typeInfo);
            }
            else if (value.IsGraphql)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.GraphQLContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.GraphQLContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.GraphQLContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Graphql!, typeInfo);
            }
            else if (value.IsWebAccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.WebAccessContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.WebAccessContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.WebAccessContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebAccess!, typeInfo);
            }
        }
    }
}