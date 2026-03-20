#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data : global::System.IEquatable<Data>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.CategoricalAnnotationConfig? Categorical { get; init; }
#else
        public global::Phoenix.CategoricalAnnotationConfig? Categorical { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Categorical))]
#endif
        public bool IsCategorical => Categorical != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ContinuousAnnotationConfig? Continuous { get; init; }
#else
        public global::Phoenix.ContinuousAnnotationConfig? Continuous { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Continuous))]
#endif
        public bool IsContinuous => Continuous != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.FreeformAnnotationConfig? Freeform { get; init; }
#else
        public global::Phoenix.FreeformAnnotationConfig? Freeform { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Freeform))]
#endif
        public bool IsFreeform => Freeform != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Phoenix.CategoricalAnnotationConfig value) => new Data((global::Phoenix.CategoricalAnnotationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.CategoricalAnnotationConfig?(Data @this) => @this.Categorical;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Phoenix.CategoricalAnnotationConfig? value)
        {
            Categorical = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Phoenix.ContinuousAnnotationConfig value) => new Data((global::Phoenix.ContinuousAnnotationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ContinuousAnnotationConfig?(Data @this) => @this.Continuous;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Phoenix.ContinuousAnnotationConfig? value)
        {
            Continuous = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Phoenix.FreeformAnnotationConfig value) => new Data((global::Phoenix.FreeformAnnotationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.FreeformAnnotationConfig?(Data @this) => @this.Freeform;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Phoenix.FreeformAnnotationConfig? value)
        {
            Freeform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data(
            global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType? type,
            global::Phoenix.CategoricalAnnotationConfig? categorical,
            global::Phoenix.ContinuousAnnotationConfig? continuous,
            global::Phoenix.FreeformAnnotationConfig? freeform
            )
        {
            Type = type;

            Categorical = categorical;
            Continuous = continuous;
            Freeform = freeform;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Freeform as object ??
            Continuous as object ??
            Categorical as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Categorical?.ToString() ??
            Continuous?.ToString() ??
            Freeform?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCategorical && !IsContinuous && !IsFreeform || !IsCategorical && IsContinuous && !IsFreeform || !IsCategorical && !IsContinuous && IsFreeform;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.CategoricalAnnotationConfig?, TResult>? categorical = null,
            global::System.Func<global::Phoenix.ContinuousAnnotationConfig?, TResult>? continuous = null,
            global::System.Func<global::Phoenix.FreeformAnnotationConfig?, TResult>? freeform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCategorical && categorical != null)
            {
                return categorical(Categorical!);
            }
            else if (IsContinuous && continuous != null)
            {
                return continuous(Continuous!);
            }
            else if (IsFreeform && freeform != null)
            {
                return freeform(Freeform!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.CategoricalAnnotationConfig?>? categorical = null,
            global::System.Action<global::Phoenix.ContinuousAnnotationConfig?>? continuous = null,
            global::System.Action<global::Phoenix.FreeformAnnotationConfig?>? freeform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCategorical)
            {
                categorical?.Invoke(Categorical!);
            }
            else if (IsContinuous)
            {
                continuous?.Invoke(Continuous!);
            }
            else if (IsFreeform)
            {
                freeform?.Invoke(Freeform!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Categorical,
                typeof(global::Phoenix.CategoricalAnnotationConfig),
                Continuous,
                typeof(global::Phoenix.ContinuousAnnotationConfig),
                Freeform,
                typeof(global::Phoenix.FreeformAnnotationConfig),
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
        public bool Equals(Data other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.CategoricalAnnotationConfig?>.Default.Equals(Categorical, other.Categorical) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ContinuousAnnotationConfig?>.Default.Equals(Continuous, other.Continuous) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.FreeformAnnotationConfig?>.Default.Equals(Freeform, other.Freeform) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data obj1, Data obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data obj1, Data obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data o && Equals(o);
        }
    }
}
