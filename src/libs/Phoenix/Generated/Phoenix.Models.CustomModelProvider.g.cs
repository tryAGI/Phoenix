
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomModelProvider
    {
        /// <summary>
        /// The ID of the custom provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique name of the custom provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional description of the custom provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The free-form provider label recorded on the custom provider. Unlike the `provider` of a built-in family, this is not drawn from a fixed set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The SDK used to communicate with the custom provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.CustomModelProviderSdkJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.CustomModelProviderSdk Sdk { get; set; }

        /// <summary>
        /// The time the custom provider was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time the custom provider was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModelProvider" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the custom provider.
        /// </param>
        /// <param name="name">
        /// The unique name of the custom provider.
        /// </param>
        /// <param name="provider">
        /// The free-form provider label recorded on the custom provider. Unlike the `provider` of a built-in family, this is not drawn from a fixed set.
        /// </param>
        /// <param name="sdk">
        /// The SDK used to communicate with the custom provider.
        /// </param>
        /// <param name="createdAt">
        /// The time the custom provider was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time the custom provider was last updated.
        /// </param>
        /// <param name="description">
        /// An optional description of the custom provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomModelProvider(
            string id,
            string name,
            string provider,
            global::Phoenix.CustomModelProviderSdk sdk,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Sdk = sdk;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModelProvider" /> class.
        /// </summary>
        public CustomModelProvider()
        {
        }

    }
}