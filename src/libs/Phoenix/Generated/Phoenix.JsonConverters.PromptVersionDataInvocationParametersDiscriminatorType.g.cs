#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptVersionDataInvocationParametersDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType Read(
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
                        return global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
