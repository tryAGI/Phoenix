#nullable enable

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadDatasetRequestActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.UploadDatasetRequestAction>
    {
        /// <inheritdoc />
        public override global::Phoenix.UploadDatasetRequestAction Read(
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
                        return global::Phoenix.UploadDatasetRequestActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Phoenix.UploadDatasetRequestAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Phoenix.UploadDatasetRequestAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.UploadDatasetRequestAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Phoenix.UploadDatasetRequestActionExtensions.ToValueString(value));
        }
    }
}
