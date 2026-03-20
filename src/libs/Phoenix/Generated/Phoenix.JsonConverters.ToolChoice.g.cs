#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class ToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ToolChoice>
    {
        /// <inheritdoc />
        public override global::Phoenix.ToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolsToolChoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolsToolChoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptToolsToolChoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.PromptToolChoiceNone? none = default;
            if (discriminator?.Type == global::Phoenix.PromptToolsToolChoiceDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptToolChoiceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptToolChoiceZeroOrMore? zeroOrMore = default;
            if (discriminator?.Type == global::Phoenix.PromptToolsToolChoiceDiscriminatorType.ZeroOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceZeroOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceZeroOrMore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptToolChoiceZeroOrMore)}");
                zeroOrMore = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptToolChoiceOneOrMore? oneOrMore = default;
            if (discriminator?.Type == global::Phoenix.PromptToolsToolChoiceDiscriminatorType.OneOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceOneOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceOneOrMore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptToolChoiceOneOrMore)}");
                oneOrMore = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.PromptToolChoiceSpecificFunctionTool? specificFunction = default;
            if (discriminator?.Type == global::Phoenix.PromptToolsToolChoiceDiscriminatorType.SpecificFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceSpecificFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceSpecificFunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.PromptToolChoiceSpecificFunctionTool)}");
                specificFunction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.ToolChoice(
                discriminator?.Type,
                none,

                zeroOrMore,

                oneOrMore,

                specificFunction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptToolChoiceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None, typeInfo);
            }
            else if (value.IsZeroOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceZeroOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceZeroOrMore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptToolChoiceZeroOrMore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ZeroOrMore, typeInfo);
            }
            else if (value.IsOneOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceOneOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceOneOrMore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptToolChoiceOneOrMore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OneOrMore, typeInfo);
            }
            else if (value.IsSpecificFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.PromptToolChoiceSpecificFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.PromptToolChoiceSpecificFunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.PromptToolChoiceSpecificFunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpecificFunction, typeInfo);
            }
        }
    }
}