#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatV2ChatV2PostRequestDiscriminatorTriggerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger?>
    {
        /// <inheritdoc />
        public override global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger? Read(
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
                        return global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTriggerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTriggerExtensions.ToValueString(value.Value));
            }
        }
    }
}
