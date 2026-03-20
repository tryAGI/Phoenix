#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct User : global::System.IEquatable<User>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod? AuthMethod { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.LocalUserData? Local { get; init; }
#else
        public global::Phoenix.LocalUserData? Local { get; }
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
        public global::Phoenix.OAuth2UserData? Oauth2 { get; init; }
#else
        public global::Phoenix.OAuth2UserData? Oauth2 { get; }
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
        public global::Phoenix.LDAPUserData? Ldap { get; init; }
#else
        public global::Phoenix.LDAPUserData? Ldap { get; }
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
        public static implicit operator User(global::Phoenix.LocalUserData value) => new User((global::Phoenix.LocalUserData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LocalUserData?(User @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public User(global::Phoenix.LocalUserData? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator User(global::Phoenix.OAuth2UserData value) => new User((global::Phoenix.OAuth2UserData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.OAuth2UserData?(User @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public User(global::Phoenix.OAuth2UserData? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator User(global::Phoenix.LDAPUserData value) => new User((global::Phoenix.LDAPUserData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LDAPUserData?(User @this) => @this.Ldap;

        /// <summary>
        /// 
        /// </summary>
        public User(global::Phoenix.LDAPUserData? value)
        {
            Ldap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public User(
            global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod? authMethod,
            global::Phoenix.LocalUserData? local,
            global::Phoenix.OAuth2UserData? oauth2,
            global::Phoenix.LDAPUserData? ldap
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
            global::System.Func<global::Phoenix.LocalUserData?, TResult>? local = null,
            global::System.Func<global::Phoenix.OAuth2UserData?, TResult>? oauth2 = null,
            global::System.Func<global::Phoenix.LDAPUserData?, TResult>? ldap = null,
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
            global::System.Action<global::Phoenix.LocalUserData?>? local = null,
            global::System.Action<global::Phoenix.OAuth2UserData?>? oauth2 = null,
            global::System.Action<global::Phoenix.LDAPUserData?>? ldap = null,
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
                typeof(global::Phoenix.LocalUserData),
                Oauth2,
                typeof(global::Phoenix.OAuth2UserData),
                Ldap,
                typeof(global::Phoenix.LDAPUserData),
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
        public bool Equals(User other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LocalUserData?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.OAuth2UserData?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LDAPUserData?>.Default.Equals(Ldap, other.Ldap) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(User obj1, User obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<User>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(User obj1, User obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is User o && Equals(o);
        }
    }
}
