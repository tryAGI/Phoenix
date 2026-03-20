#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateAnnotationConfigData : global::System.IEquatable<CreateAnnotationConfigData>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.CategoricalAnnotationConfigData? Categorical { get; init; }
#else
        public global::Phoenix.CategoricalAnnotationConfigData? Categorical { get; }
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
        public global::Phoenix.ContinuousAnnotationConfigData? Continuous { get; init; }
#else
        public global::Phoenix.ContinuousAnnotationConfigData? Continuous { get; }
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
        public global::Phoenix.FreeformAnnotationConfigData? Freeform { get; init; }
#else
        public global::Phoenix.FreeformAnnotationConfigData? Freeform { get; }
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
        public static implicit operator CreateAnnotationConfigData(global::Phoenix.CategoricalAnnotationConfigData value) => new CreateAnnotationConfigData((global::Phoenix.CategoricalAnnotationConfigData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.CategoricalAnnotationConfigData?(CreateAnnotationConfigData @this) => @this.Categorical;

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(global::Phoenix.CategoricalAnnotationConfigData? value)
        {
            Categorical = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAnnotationConfigData(global::Phoenix.ContinuousAnnotationConfigData value) => new CreateAnnotationConfigData((global::Phoenix.ContinuousAnnotationConfigData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ContinuousAnnotationConfigData?(CreateAnnotationConfigData @this) => @this.Continuous;

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(global::Phoenix.ContinuousAnnotationConfigData? value)
        {
            Continuous = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAnnotationConfigData(global::Phoenix.FreeformAnnotationConfigData value) => new CreateAnnotationConfigData((global::Phoenix.FreeformAnnotationConfigData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.FreeformAnnotationConfigData?(CreateAnnotationConfigData @this) => @this.Freeform;

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(global::Phoenix.FreeformAnnotationConfigData? value)
        {
            Freeform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(
            global::Phoenix.CreateAnnotationConfigDataDiscriminatorType? type,
            global::Phoenix.CategoricalAnnotationConfigData? categorical,
            global::Phoenix.ContinuousAnnotationConfigData? continuous,
            global::Phoenix.FreeformAnnotationConfigData? freeform
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
            global::System.Func<global::Phoenix.CategoricalAnnotationConfigData?, TResult>? categorical = null,
            global::System.Func<global::Phoenix.ContinuousAnnotationConfigData?, TResult>? continuous = null,
            global::System.Func<global::Phoenix.FreeformAnnotationConfigData?, TResult>? freeform = null,
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
            global::System.Action<global::Phoenix.CategoricalAnnotationConfigData?>? categorical = null,
            global::System.Action<global::Phoenix.ContinuousAnnotationConfigData?>? continuous = null,
            global::System.Action<global::Phoenix.FreeformAnnotationConfigData?>? freeform = null,
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
                typeof(global::Phoenix.CategoricalAnnotationConfigData),
                Continuous,
                typeof(global::Phoenix.ContinuousAnnotationConfigData),
                Freeform,
                typeof(global::Phoenix.FreeformAnnotationConfigData),
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
        public bool Equals(CreateAnnotationConfigData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.CategoricalAnnotationConfigData?>.Default.Equals(Categorical, other.Categorical) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ContinuousAnnotationConfigData?>.Default.Equals(Continuous, other.Continuous) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.FreeformAnnotationConfigData?>.Default.Equals(Freeform, other.Freeform) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAnnotationConfigData obj1, CreateAnnotationConfigData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAnnotationConfigData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAnnotationConfigData obj1, CreateAnnotationConfigData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAnnotationConfigData o && Equals(o);
        }
    }
}
