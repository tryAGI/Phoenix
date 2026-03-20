#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType? Read(
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
                        return global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
