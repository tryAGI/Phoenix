#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class SessionAnnotationAnnotatorKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.SessionAnnotationAnnotatorKind?>
    {
        /// <inheritdoc />
        public override global::Phoenix.SessionAnnotationAnnotatorKind? Read(
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
                        return global::Phoenix.SessionAnnotationAnnotatorKindExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.SessionAnnotationAnnotatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.SessionAnnotationAnnotatorKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.SessionAnnotationAnnotatorKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Phoenix.SessionAnnotationAnnotatorKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
