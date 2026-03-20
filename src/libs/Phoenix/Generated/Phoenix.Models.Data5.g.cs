#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data5 : global::System.IEquatable<Data5>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod? AuthMethod { get; }

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
#if NET6_0_OR_GREATER
        public global::Phoenix.AnonymousUser? Anonymous { get; init; }
#else
        public global::Phoenix.AnonymousUser? Anonymous { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anonymous))]
#endif
        public bool IsAnonymous => Anonymous != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::Phoenix.LocalUser value) => new Data5((global::Phoenix.LocalUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LocalUser?(Data5 @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::Phoenix.LocalUser? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::Phoenix.OAuth2User value) => new Data5((global::Phoenix.OAuth2User?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.OAuth2User?(Data5 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::Phoenix.OAuth2User? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::Phoenix.LDAPUser value) => new Data5((global::Phoenix.LDAPUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LDAPUser?(Data5 @this) => @this.Ldap;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::Phoenix.LDAPUser? value)
        {
            Ldap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::Phoenix.AnonymousUser value) => new Data5((global::Phoenix.AnonymousUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.AnonymousUser?(Data5 @this) => @this.Anonymous;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::Phoenix.AnonymousUser? value)
        {
            Anonymous = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data5(
            global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod? authMethod,
            global::Phoenix.LocalUser? local,
            global::Phoenix.OAuth2User? oauth2,
            global::Phoenix.LDAPUser? ldap,
            global::Phoenix.AnonymousUser? anonymous
            )
        {
            AuthMethod = authMethod;

            Local = local;
            Oauth2 = oauth2;
            Ldap = ldap;
            Anonymous = anonymous;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Anonymous as object ??
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
            Ldap?.ToString() ??
            Anonymous?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLocal && !IsOauth2 && !IsLdap && !IsAnonymous || !IsLocal && IsOauth2 && !IsLdap && !IsAnonymous || !IsLocal && !IsOauth2 && IsLdap && !IsAnonymous || !IsLocal && !IsOauth2 && !IsLdap && IsAnonymous;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.LocalUser?, TResult>? local = null,
            global::System.Func<global::Phoenix.OAuth2User?, TResult>? oauth2 = null,
            global::System.Func<global::Phoenix.LDAPUser?, TResult>? ldap = null,
            global::System.Func<global::Phoenix.AnonymousUser?, TResult>? anonymous = null,
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
            else if (IsAnonymous && anonymous != null)
            {
                return anonymous(Anonymous!);
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
            global::System.Action<global::Phoenix.AnonymousUser?>? anonymous = null,
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
            else if (IsAnonymous)
            {
                anonymous?.Invoke(Anonymous!);
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
                Anonymous,
                typeof(global::Phoenix.AnonymousUser),
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
        public bool Equals(Data5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LocalUser?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.OAuth2User?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LDAPUser?>.Default.Equals(Ldap, other.Ldap) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.AnonymousUser?>.Default.Equals(Anonymous, other.Anonymous) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data5 obj1, Data5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data5 obj1, Data5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data5 o && Equals(o);
        }
    }
}
