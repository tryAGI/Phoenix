
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Built-in playground model selection.
    /// </summary>
    public sealed partial class PlaygroundBuiltinModelContext
    {
        /// <summary>
        /// Default Value: builtin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundBuiltinModelContext" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="modelName"></param>
        /// <param name="type">
        /// Default Value: builtin
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundBuiltinModelContext(
            string provider,
            string modelName,
            string? type)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundBuiltinModelContext" /> class.
        /// </summary>
        public PlaygroundBuiltinModelContext()
        {
        }

    }
}