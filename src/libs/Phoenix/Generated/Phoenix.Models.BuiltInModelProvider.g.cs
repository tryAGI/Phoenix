
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuiltInModelProvider
    {
        /// <summary>
        /// The provider family identifier, accepted wherever a built-in model provider is specified (e.g. 'OPENAI').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ModelProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.ModelProvider Provider { get; set; }

        /// <summary>
        /// The human-readable name of the provider family (e.g. 'OpenAI').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInModelProvider" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider family identifier, accepted wherever a built-in model provider is specified (e.g. 'OPENAI').
        /// </param>
        /// <param name="name">
        /// The human-readable name of the provider family (e.g. 'OpenAI').
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltInModelProvider(
            global::Phoenix.ModelProvider provider,
            string name)
        {
            this.Provider = provider;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInModelProvider" /> class.
        /// </summary>
        public BuiltInModelProvider()
        {
        }

    }
}