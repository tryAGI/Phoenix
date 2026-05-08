#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatChatPostRoot : global::System.IEquatable<ChatChatPostRoot>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.ChatChatPostRootDiscriminatorProviderType? ProviderType { get; }

        /// <summary>
        /// Chat against a stored custom provider record.<br/>
        /// The wire format of ``provider_id`` is a relay GlobalID (e.g.<br/>
        /// ``UHJvdmlkZXI6MTM=``). It is decoded to its integer node ID at<br/>
        /// parse time so downstream consumers don't need to know the GlobalID<br/>
        /// encoding.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.CustomProviderChatSearchParams? Custom { get; init; }
#else
        public global::Phoenix.CustomProviderChatSearchParams? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.CustomProviderChatSearchParams? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// Chat against a Phoenix built-in provider.<br/>
        /// Credentials and connection details (base URL, Azure endpoint, AWS<br/>
        /// region) are resolved from the secret store first and the process<br/>
        /// environment second. ``openai_api_type`` is honoured by the OpenAI and<br/>
        /// Azure OpenAI branches; other providers ignore it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.BuiltInProviderChatSearchParams? Builtin { get; init; }
#else
        public global::Phoenix.BuiltInProviderChatSearchParams? Builtin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Builtin))]
#endif
        public bool IsBuiltin => Builtin != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBuiltin(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.BuiltInProviderChatSearchParams? value)
        {
            value = Builtin;
            return IsBuiltin;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatChatPostRoot(global::Phoenix.CustomProviderChatSearchParams value) => new ChatChatPostRoot((global::Phoenix.CustomProviderChatSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.CustomProviderChatSearchParams?(ChatChatPostRoot @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ChatChatPostRoot(global::Phoenix.CustomProviderChatSearchParams? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatChatPostRoot(global::Phoenix.BuiltInProviderChatSearchParams value) => new ChatChatPostRoot((global::Phoenix.BuiltInProviderChatSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.BuiltInProviderChatSearchParams?(ChatChatPostRoot @this) => @this.Builtin;

        /// <summary>
        /// 
        /// </summary>
        public ChatChatPostRoot(global::Phoenix.BuiltInProviderChatSearchParams? value)
        {
            Builtin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatChatPostRoot(
            global::Phoenix.ChatChatPostRootDiscriminatorProviderType? providerType,
            global::Phoenix.CustomProviderChatSearchParams? custom,
            global::Phoenix.BuiltInProviderChatSearchParams? builtin
            )
        {
            ProviderType = providerType;

            Custom = custom;
            Builtin = builtin;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Builtin as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Custom?.ToString() ??
            Builtin?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsBuiltin || !IsCustom && IsBuiltin;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.CustomProviderChatSearchParams, TResult>? custom = null,
            global::System.Func<global::Phoenix.BuiltInProviderChatSearchParams, TResult>? builtin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsBuiltin && builtin != null)
            {
                return builtin(Builtin!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.CustomProviderChatSearchParams>? custom = null,

            global::System.Action<global::Phoenix.BuiltInProviderChatSearchParams>? builtin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsBuiltin)
            {
                builtin?.Invoke(Builtin!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.CustomProviderChatSearchParams>? custom = null,
            global::System.Action<global::Phoenix.BuiltInProviderChatSearchParams>? builtin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsBuiltin)
            {
                builtin?.Invoke(Builtin!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::Phoenix.CustomProviderChatSearchParams),
                Builtin,
                typeof(global::Phoenix.BuiltInProviderChatSearchParams),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatChatPostRoot other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.CustomProviderChatSearchParams?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.BuiltInProviderChatSearchParams?>.Default.Equals(Builtin, other.Builtin) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatChatPostRoot obj1, ChatChatPostRoot obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatChatPostRoot>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatChatPostRoot obj1, ChatChatPostRoot obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatChatPostRoot o && Equals(o);
        }
    }
}
