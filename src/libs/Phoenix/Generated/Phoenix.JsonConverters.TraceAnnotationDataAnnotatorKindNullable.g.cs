#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceAnnotationDataAnnotatorKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.TraceAnnotationDataAnnotatorKind?>
    {
        /// <inheritdoc />
        public override global::Phoenix.TraceAnnotationDataAnnotatorKind? Read(
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
                        return global::Phoenix.TraceAnnotationDataAnnotatorKindExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.TraceAnnotationDataAnnotatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.TraceAnnotationDataAnnotatorKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.TraceAnnotationDataAnnotatorKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Phoenix.TraceAnnotationDataAnnotatorKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
