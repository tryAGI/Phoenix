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
            global::Phoenix.ProjectUIContext? project = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Project)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ProjectUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ProjectUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ProjectUIContext)}");
                project = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.TraceUIContext? trace = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Trace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.TraceUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.TraceUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.TraceUIContext)}");
                trace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.SessionUIContext? session = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Session)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SessionUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SessionUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.SessionUIContext)}");
                session = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptUIContext? prompt = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Prompt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptUIContext)}");
                prompt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptVersionUIContext? promptVersion = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.PromptVersion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptVersionUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptVersionUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptVersionUIContext)}");
                promptVersion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.SpanUIContext? span = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Span)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SpanUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SpanUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.SpanUIContext)}");
                span = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PlaygroundUIContext? playground = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Playground)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PlaygroundUIContext)}");
                playground = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.CodeEvaluatorUIContext? codeEvaluator = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.CodeEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CodeEvaluatorUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CodeEvaluatorUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CodeEvaluatorUIContext)}");
                codeEvaluator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.LlmEvaluatorUIContext? llmEvaluator = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.LlmEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LlmEvaluatorUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LlmEvaluatorUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LlmEvaluatorUIContext)}");
                llmEvaluator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.DatasetUIContext? dataset = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Dataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.DatasetUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.DatasetUIContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.DatasetUIContext)}");
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
            global::Phoenix.SubagentsContext? subagents = default;
            if (discriminator?.Type == global::Phoenix.ChatContextDiscriminatorType.Subagents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SubagentsContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SubagentsContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.SubagentsContext)}");
                subagents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ChatContext(
                discriminator?.Type,
                app,

                project,

                trace,

                session,

                prompt,

                promptVersion,

                span,

                playground,

                codeEvaluator,

                llmEvaluator,

                dataset,

                graphql,

                webAccess,

                subagents
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ProjectUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ProjectUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.ProjectUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Project!, typeInfo);
            }
            else if (value.IsTrace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.TraceUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.TraceUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.TraceUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trace!, typeInfo);
            }
            else if (value.IsSession)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SessionUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SessionUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.SessionUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Session!, typeInfo);
            }
            else if (value.IsPrompt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Prompt!, typeInfo);
            }
            else if (value.IsPromptVersion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptVersionUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptVersionUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptVersionUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromptVersion!, typeInfo);
            }
            else if (value.IsSpan)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SpanUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SpanUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.SpanUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Span!, typeInfo);
            }
            else if (value.IsPlayground)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PlaygroundUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PlaygroundUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PlaygroundUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Playground!, typeInfo);
            }
            else if (value.IsCodeEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CodeEvaluatorUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CodeEvaluatorUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.CodeEvaluatorUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeEvaluator!, typeInfo);
            }
            else if (value.IsLlmEvaluator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LlmEvaluatorUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LlmEvaluatorUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LlmEvaluatorUIContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LlmEvaluator!, typeInfo);
            }
            else if (value.IsDataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.DatasetUIContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.DatasetUIContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.DatasetUIContext).Name}");
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
            else if (value.IsSubagents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SubagentsContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SubagentsContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.SubagentsContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Subagents!, typeInfo);
            }
        }
    }
}