#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem2 : global::System.IEquatable<DataItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod? AuthMethod { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.LocalUser? Local { get; init; }
#else
        public global::Phoenix.LocalUser? Local { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Local))]
#endif
        public bool IsLocal => Local != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.OAuth2User? Oauth2 { get; init; }
#else
        public global::Phoenix.OAuth2User? Oauth2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2))]
#endif
        public bool IsOauth2 => Oauth2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.LDAPUser? Ldap { get; init; }
#else
        public global::Phoenix.LDAPUser? Ldap { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ldap))]
#endif
        public bool IsLdap => Ldap != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::Phoenix.LocalUser value) => new DataItem2((global::Phoenix.LocalUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LocalUser?(DataItem2 @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Phoenix.LocalUser? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::Phoenix.OAuth2User value) => new DataItem2((global::Phoenix.OAuth2User?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.OAuth2User?(DataItem2 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Phoenix.OAuth2User? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::Phoenix.LDAPUser value) => new DataItem2((global::Phoenix.LDAPUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LDAPUser?(DataItem2 @this) => @this.Ldap;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Phoenix.LDAPUser? value)
        {
            Ldap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(
            global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod? authMethod,
            global::Phoenix.LocalUser? local,
            global::Phoenix.OAuth2User? oauth2,
            global::Phoenix.LDAPUser? ldap
            )
        {
            AuthMethod = authMethod;

            Local = local;
            Oauth2 = oauth2;
            Ldap = ldap;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Ldap as object ??
            Oauth2 as object ??
            Local as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Local?.ToString() ??
            Oauth2?.ToString() ??
            Ldap?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLocal && !IsOauth2 && !IsLdap || !IsLocal && IsOauth2 && !IsLdap || !IsLocal && !IsOauth2 && IsLdap;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.LocalUser?, TResult>? local = null,
            global::System.Func<global::Phoenix.OAuth2User?, TResult>? oauth2 = null,
            global::System.Func<global::Phoenix.LDAPUser?, TResult>? ldap = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocal && local != null)
            {
                return local(Local!);
            }
            else if (IsOauth2 && oauth2 != null)
            {
                return oauth2(Oauth2!);
            }
            else if (IsLdap && ldap != null)
            {
                return ldap(Ldap!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.LocalUser?>? local = null,
            global::System.Action<global::Phoenix.OAuth2User?>? oauth2 = null,
            global::System.Action<global::Phoenix.LDAPUser?>? ldap = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocal)
            {
                local?.Invoke(Local!);
            }
            else if (IsOauth2)
            {
                oauth2?.Invoke(Oauth2!);
            }
            else if (IsLdap)
            {
                ldap?.Invoke(Ldap!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Local,
                typeof(global::Phoenix.LocalUser),
                Oauth2,
                typeof(global::Phoenix.OAuth2User),
                Ldap,
                typeof(global::Phoenix.LDAPUser),
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
        public bool Equals(DataItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LocalUser?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.OAuth2User?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LDAPUser?>.Default.Equals(Ldap, other.Ldap) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem2 obj1, DataItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem2 obj1, DataItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem2 o && Equals(o);
        }
    }
}
