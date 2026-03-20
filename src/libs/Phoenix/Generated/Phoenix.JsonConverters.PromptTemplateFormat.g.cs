#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptTemplateFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.PromptTemplateFormat>
    {
        /// <inheritdoc />
        public override global::Phoenix.PromptTemplateFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Phoenix.PromptTemplateFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.PromptTemplateFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.PromptTemplateFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.PromptTemplateFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Phoenix.PromptTemplateFormatExtensions.ToValueString(value));
        }
    }
}
