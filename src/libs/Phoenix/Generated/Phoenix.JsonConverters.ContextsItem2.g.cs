#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ContextsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ContextsItem2>
    {
        /// <inheritdoc />
        public override global::Phoenix.ContextsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.SubmitMessageContextDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.SubmitMessageContextDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.SubmitMessageContextDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.AppContext? app = default;
            if (discriminator?.Type == global::Phoenix.SubmitMessageContextDiscriminatorType.App)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AppContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AppContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.AppContext)}");
                app = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.ProjectContext? project = default;
            if (discriminator?.Type == global::Phoenix.SubmitMessageContextDiscriminatorType.Project)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.ProjectContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.ProjectContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.ProjectContext)}");
                project = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.TraceContext? trace = default;
            if (discriminator?.Type == global::Phoenix.SubmitMessageContextDiscriminatorType.Trace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.TraceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.TraceContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.TraceContext)}");
                trace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.AgentSpanContext? span = default;
            if (discriminator?.Type == global::Phoenix.SubmitMessageContextDiscriminatorType.Span)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.AgentSpanContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.AgentSpanContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.AgentSpanContext)}");
                span = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ContextsItem2(
                discriminator?.Type,
                app,

                project,

                trace,

                span
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ContextsItem2 value,
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
        }
    }
}