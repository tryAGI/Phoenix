
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnonymousUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.User), TypeInfoPropertyName = "User2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod), TypeInfoPropertyName = "CreateUserRequestBodyUserDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data3), TypeInfoPropertyName = "Data32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod), TypeInfoPropertyName = "CreateUserResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem3), TypeInfoPropertyName = "DataItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod), TypeInfoPropertyName = "GetUsersResponseBodyDataItemDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data6), TypeInfoPropertyName = "Data62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod), TypeInfoPropertyName = "GetViewerResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserRole), TypeInfoPropertyName = "LDAPUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserDataRole), TypeInfoPropertyName = "LDAPUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserRole), TypeInfoPropertyName = "LocalUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserDataRole), TypeInfoPropertyName = "LocalUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserRole), TypeInfoPropertyName = "OAuth2UserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserDataRole), TypeInfoPropertyName = "OAuth2UserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.User?), TypeInfoPropertyName = "NullableUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableCreateUserRequestBodyUserDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data3?), TypeInfoPropertyName = "NullableData32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableCreateUserResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem3?), TypeInfoPropertyName = "NullableDataItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableGetUsersResponseBodyDataItemDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data6?), TypeInfoPropertyName = "NullableData62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableGetViewerResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserRole?), TypeInfoPropertyName = "NullableLDAPUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserDataRole?), TypeInfoPropertyName = "NullableLDAPUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserRole?), TypeInfoPropertyName = "NullableLocalUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserDataRole?), TypeInfoPropertyName = "NullableLocalUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserRole?), TypeInfoPropertyName = "NullableOAuth2UserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserDataRole?), TypeInfoPropertyName = "NullableOAuth2UserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem3>))]
    internal sealed partial class UsersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Phoenix.JsonConverters.UserJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data3JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItem3JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data6JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Phoenix.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod)

                    || typeToConvert == typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod?)

                    || typeToConvert == typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod)

                    || typeToConvert == typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod?)

                    || typeToConvert == typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod)

                    || typeToConvert == typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod?)

                    || typeToConvert == typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod)

                    || typeToConvert == typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod?)

                    || typeToConvert == typeof(global::Phoenix.LDAPUserRole)

                    || typeToConvert == typeof(global::Phoenix.LDAPUserRole?)

                    || typeToConvert == typeof(global::Phoenix.LDAPUserDataRole)

                    || typeToConvert == typeof(global::Phoenix.LDAPUserDataRole?)

                    || typeToConvert == typeof(global::Phoenix.LocalUserRole)

                    || typeToConvert == typeof(global::Phoenix.LocalUserRole?)

                    || typeToConvert == typeof(global::Phoenix.LocalUserDataRole)

                    || typeToConvert == typeof(global::Phoenix.LocalUserDataRole?)

                    || typeToConvert == typeof(global::Phoenix.OAuth2UserRole)

                    || typeToConvert == typeof(global::Phoenix.OAuth2UserRole?)

                    || typeToConvert == typeof(global::Phoenix.OAuth2UserDataRole)

                    || typeToConvert == typeof(global::Phoenix.OAuth2UserDataRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod))
                {
                    return new global::Phoenix.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod?))
                {
                    return new global::Phoenix.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod))
                {
                    return new global::Phoenix.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod?))
                {
                    return new global::Phoenix.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod))
                {
                    return new global::Phoenix.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod?))
                {
                    return new global::Phoenix.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod))
                {
                    return new global::Phoenix.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod?))
                {
                    return new global::Phoenix.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LDAPUserRole))
                {
                    return new global::Phoenix.JsonConverters.LDAPUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LDAPUserRole?))
                {
                    return new global::Phoenix.JsonConverters.LDAPUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LDAPUserDataRole))
                {
                    return new global::Phoenix.JsonConverters.LDAPUserDataRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LDAPUserDataRole?))
                {
                    return new global::Phoenix.JsonConverters.LDAPUserDataRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LocalUserRole))
                {
                    return new global::Phoenix.JsonConverters.LocalUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LocalUserRole?))
                {
                    return new global::Phoenix.JsonConverters.LocalUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LocalUserDataRole))
                {
                    return new global::Phoenix.JsonConverters.LocalUserDataRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.LocalUserDataRole?))
                {
                    return new global::Phoenix.JsonConverters.LocalUserDataRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OAuth2UserRole))
                {
                    return new global::Phoenix.JsonConverters.OAuth2UserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OAuth2UserRole?))
                {
                    return new global::Phoenix.JsonConverters.OAuth2UserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OAuth2UserDataRole))
                {
                    return new global::Phoenix.JsonConverters.OAuth2UserDataRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.OAuth2UserDataRole?))
                {
                    return new global::Phoenix.JsonConverters.OAuth2UserDataRoleNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new UsersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}