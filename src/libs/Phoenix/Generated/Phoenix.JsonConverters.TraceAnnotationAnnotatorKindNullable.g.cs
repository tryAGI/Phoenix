#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceAnnotationAnnotatorKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.TraceAnnotationAnnotatorKind?>
    {
        /// <inheritdoc />
        public override global::Phoenix.TraceAnnotationAnnotatorKind? Read(
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
                        return global::Phoenix.TraceAnnotationAnnotatorKindExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.TraceAnnotationAnnotatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.TraceAnnotationAnnotatorKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.TraceAnnotationAnnotatorKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Phoenix.TraceAnnotationAnnotatorKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
