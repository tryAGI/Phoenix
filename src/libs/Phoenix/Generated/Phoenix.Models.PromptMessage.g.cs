
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptMessage(
            global::Phoenix.PromptMessageRole role,
            global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMessage" /> class.
        /// </summary>
        public PromptMessage()
        {
        }
    }
}