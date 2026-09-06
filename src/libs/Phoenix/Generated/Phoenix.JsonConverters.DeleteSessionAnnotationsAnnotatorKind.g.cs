#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteSessionAnnotationsAnnotatorKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.DeleteSessionAnnotationsAnnotatorKind>
    {
        /// <inheritdoc />
        public override global::Phoenix.DeleteSessionAnnotationsAnnotatorKind Read(
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
                        return global::Phoenix.DeleteSessionAnnotationsAnnotatorKindExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.DeleteSessionAnnotationsAnnotatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.DeleteSessionAnnotationsAnnotatorKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Phoenix.DeleteSessionAnnotationsAnnotatorKindExtensions.ToValueString(value));
        }
    }
}
