#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContextsItem : global::System.IEquatable<ContextsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.RegenerateMessageContextDiscriminatorType? Type { get; }

        /// <summary>
        /// Per-turn browser clock context for resolving relative time requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.AppContext? App { get; init; }
#else
        public global::Phoenix.AppContext? App { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(App))]
#endif
        public bool IsApp => App != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.AppContext? value)
        {
            value = App;
            return IsApp;
        }

        /// <summary>
        /// Project the user is currently viewing.<br/>
        /// ``span_filter`` carries the project-scoped span filter expression when the<br/>
        /// span filter field is mounted — empty string when the field is mounted with<br/>
        /// no condition applied, ``None`` when the field is not present at all.<br/>
        /// ``root_spans_only`` carries the current state of the spans-table root vs.<br/>
        /// all toggle when that toggle is mounted — ``True`` when the table is<br/>
        /// restricted to root spans, ``False`` when it shows every span, ``None``<br/>
        /// when the toggle is not present (e.g. on the traces tab).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ProjectContext? Project { get; init; }
#else
        public global::Phoenix.ProjectContext? Project { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Project))]
#endif
        public bool IsProject => Project != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.ProjectContext? value)
        {
            value = Project;
            return IsProject;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.TraceContext? Trace { get; init; }
#else
        public global::Phoenix.TraceContext? Trace { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Trace))]
#endif
        public bool IsTrace => Trace != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.TraceContext? value)
        {
            value = Trace;
            return IsTrace;
        }

        /// <summary>
        /// Span the user has selected.<br/>
        /// Exactly one of ``span_node_id`` (relay) or ``otel_span_id`` (OpenTelemetry<br/>
        /// hex) must be set. ``project_node_id`` is optional because a span can be<br/>
        /// selected from views outside a project route.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.AgentSpanContext? Span { get; init; }
#else
        public global::Phoenix.AgentSpanContext? Span { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Span))]
#endif
        public bool IsSpan => Span != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpan(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.AgentSpanContext? value)
        {
            value = Span;
            return IsSpan;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextsItem(global::Phoenix.AppContext value) => new ContextsItem((global::Phoenix.AppContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.AppContext?(ContextsItem @this) => @this.App;

        /// <summary>
        /// 
        /// </summary>
        public ContextsItem(global::Phoenix.AppContext? value)
        {
            App = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextsItem(global::Phoenix.ProjectContext value) => new ContextsItem((global::Phoenix.ProjectContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ProjectContext?(ContextsItem @this) => @this.Project;

        /// <summary>
        /// 
        /// </summary>
        public ContextsItem(global::Phoenix.ProjectContext? value)
        {
            Project = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextsItem(global::Phoenix.TraceContext value) => new ContextsItem((global::Phoenix.TraceContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.TraceContext?(ContextsItem @this) => @this.Trace;

        /// <summary>
        /// 
        /// </summary>
        public ContextsItem(global::Phoenix.TraceContext? value)
        {
            Trace = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextsItem(global::Phoenix.AgentSpanContext value) => new ContextsItem((global::Phoenix.AgentSpanContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.AgentSpanContext?(ContextsItem @this) => @this.Span;

        /// <summary>
        /// 
        /// </summary>
        public ContextsItem(global::Phoenix.AgentSpanContext? value)
        {
            Span = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContextsItem(
            global::Phoenix.RegenerateMessageContextDiscriminatorType? type,
            global::Phoenix.AppContext? app,
            global::Phoenix.ProjectContext? project,
            global::Phoenix.TraceContext? trace,
            global::Phoenix.AgentSpanContext? span
            )
        {
            Type = type;

            App = app;
            Project = project;
            Trace = trace;
            Span = span;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Span as object ??
            Trace as object ??
            Project as object ??
            App as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            App?.ToString() ??
            Project?.ToString() ??
            Trace?.ToString() ??
            Span?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApp && !IsProject && !IsTrace && !IsSpan || !IsApp && IsProject && !IsTrace && !IsSpan || !IsApp && !IsProject && IsTrace && !IsSpan || !IsApp && !IsProject && !IsTrace && IsSpan;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.AppContext, TResult>? app = null,
            global::System.Func<global::Phoenix.ProjectContext, TResult>? project = null,
            global::System.Func<global::Phoenix.TraceContext, TResult>? trace = null,
            global::System.Func<global::Phoenix.AgentSpanContext, TResult>? span = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp && app != null)
            {
                return app(App!);
            }
            else if (IsProject && project != null)
            {
                return project(Project!);
            }
            else if (IsTrace && trace != null)
            {
                return trace(Trace!);
            }
            else if (IsSpan && span != null)
            {
                return span(Span!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.AppContext>? app = null,

            global::System.Action<global::Phoenix.ProjectContext>? project = null,

            global::System.Action<global::Phoenix.TraceContext>? trace = null,

            global::System.Action<global::Phoenix.AgentSpanContext>? span = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp)
            {
                app?.Invoke(App!);
            }
            else if (IsProject)
            {
                project?.Invoke(Project!);
            }
            else if (IsTrace)
            {
                trace?.Invoke(Trace!);
            }
            else if (IsSpan)
            {
                span?.Invoke(Span!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.AppContext>? app = null,
            global::System.Action<global::Phoenix.ProjectContext>? project = null,
            global::System.Action<global::Phoenix.TraceContext>? trace = null,
            global::System.Action<global::Phoenix.AgentSpanContext>? span = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp)
            {
                app?.Invoke(App!);
            }
            else if (IsProject)
            {
                project?.Invoke(Project!);
            }
            else if (IsTrace)
            {
                trace?.Invoke(Trace!);
            }
            else if (IsSpan)
            {
                span?.Invoke(Span!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                App,
                typeof(global::Phoenix.AppContext),
                Project,
                typeof(global::Phoenix.ProjectContext),
                Trace,
                typeof(global::Phoenix.TraceContext),
                Span,
                typeof(global::Phoenix.AgentSpanContext),
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
        public bool Equals(ContextsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.AppContext?>.Default.Equals(App, other.App) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ProjectContext?>.Default.Equals(Project, other.Project) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.TraceContext?>.Default.Equals(Trace, other.Trace) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.AgentSpanContext?>.Default.Equals(Span, other.Span) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContextsItem obj1, ContextsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContextsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContextsItem obj1, ContextsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContextsItem o && Equals(o);
        }
    }
}
