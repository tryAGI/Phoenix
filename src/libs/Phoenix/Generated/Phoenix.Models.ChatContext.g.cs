#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Discriminated union of every UI-state context the agent understands.
    /// </summary>
    public readonly partial struct ChatContext : global::System.IEquatable<ChatContext>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatContextDiscriminatorType? Type { get; }

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
        ///
        /// </summary>
        public global::Phoenix.AppContext PickApp() => IsApp
            ? App!
            : throw new global::System.InvalidOperationException($"Expected union variant 'App' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ProjectUIContext? Project { get; init; }
#else
        public global::Phoenix.ProjectUIContext? Project { get; }
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
            out global::Phoenix.ProjectUIContext? value)
        {
            value = Project;
            return IsProject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ProjectUIContext PickProject() => IsProject
            ? Project!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Project' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.TraceUIContext? Trace { get; init; }
#else
        public global::Phoenix.TraceUIContext? Trace { get; }
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
            out global::Phoenix.TraceUIContext? value)
        {
            value = Trace;
            return IsTrace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceUIContext PickTrace() => IsTrace
            ? Trace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Trace' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.SessionUIContext? Session { get; init; }
#else
        public global::Phoenix.SessionUIContext? Session { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Session))]
#endif
        public bool IsSession => Session != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSession(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.SessionUIContext? value)
        {
            value = Session;
            return IsSession;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionUIContext PickSession() => IsSession
            ? Session!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Session' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptUIContext? Prompt { get; init; }
#else
        public global::Phoenix.PromptUIContext? Prompt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Prompt))]
#endif
        public bool IsPrompt => Prompt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.PromptUIContext? value)
        {
            value = Prompt;
            return IsPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptUIContext PickPrompt() => IsPrompt
            ? Prompt!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Prompt' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptVersionUIContext? PromptVersion { get; init; }
#else
        public global::Phoenix.PromptVersionUIContext? PromptVersion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptVersion))]
#endif
        public bool IsPromptVersion => PromptVersion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPromptVersion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.PromptVersionUIContext? value)
        {
            value = PromptVersion;
            return IsPromptVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionUIContext PickPromptVersion() => IsPromptVersion
            ? PromptVersion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PromptVersion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.SpanUIContext? Span { get; init; }
#else
        public global::Phoenix.SpanUIContext? Span { get; }
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
            out global::Phoenix.SpanUIContext? value)
        {
            value = Span;
            return IsSpan;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanUIContext PickSpan() => IsSpan
            ? Span!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Span' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PlaygroundUIContext? Playground { get; init; }
#else
        public global::Phoenix.PlaygroundUIContext? Playground { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Playground))]
#endif
        public bool IsPlayground => Playground != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPlayground(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.PlaygroundUIContext? value)
        {
            value = Playground;
            return IsPlayground;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundUIContext PickPlayground() => IsPlayground
            ? Playground!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Playground' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.CodeEvaluatorUIContext? CodeEvaluator { get; init; }
#else
        public global::Phoenix.CodeEvaluatorUIContext? CodeEvaluator { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeEvaluator))]
#endif
        public bool IsCodeEvaluator => CodeEvaluator != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.CodeEvaluatorUIContext? value)
        {
            value = CodeEvaluator;
            return IsCodeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CodeEvaluatorUIContext PickCodeEvaluator() => IsCodeEvaluator
            ? CodeEvaluator!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeEvaluator' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.LlmEvaluatorUIContext? LlmEvaluator { get; init; }
#else
        public global::Phoenix.LlmEvaluatorUIContext? LlmEvaluator { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LlmEvaluator))]
#endif
        public bool IsLlmEvaluator => LlmEvaluator != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLlmEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.LlmEvaluatorUIContext? value)
        {
            value = LlmEvaluator;
            return IsLlmEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LlmEvaluatorUIContext PickLlmEvaluator() => IsLlmEvaluator
            ? LlmEvaluator!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LlmEvaluator' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.DatasetUIContext? Dataset { get; init; }
#else
        public global::Phoenix.DatasetUIContext? Dataset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dataset))]
#endif
        public bool IsDataset => Dataset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDataset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.DatasetUIContext? value)
        {
            value = Dataset;
            return IsDataset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetUIContext PickDataset() => IsDataset
            ? Dataset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dataset' but the value was {ToString()}.");

        /// <summary>
        /// Deprecated GraphQL mutations opt-in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.GraphQLContext? Graphql { get; init; }
#else
        public global::Phoenix.GraphQLContext? Graphql { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Graphql))]
#endif
        public bool IsGraphql => Graphql != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGraphql(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.GraphQLContext? value)
        {
            value = Graphql;
            return IsGraphql;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GraphQLContext PickGraphql() => IsGraphql
            ? Graphql!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Graphql' but the value was {ToString()}.");

        /// <summary>
        /// User's per-turn request to expose web search / fetch tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.WebAccessContext? WebAccess { get; init; }
#else
        public global::Phoenix.WebAccessContext? WebAccess { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebAccess))]
#endif
        public bool IsWebAccess => WebAccess != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebAccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.WebAccessContext? value)
        {
            value = WebAccess;
            return IsWebAccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.WebAccessContext PickWebAccess() => IsWebAccess
            ? WebAccess!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebAccess' but the value was {ToString()}.");

        /// <summary>
        /// User's per-turn request to expose the subagent-spawning tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.SubagentsContext? Subagents { get; init; }
#else
        public global::Phoenix.SubagentsContext? Subagents { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Subagents))]
#endif
        public bool IsSubagents => Subagents != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubagents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.SubagentsContext? value)
        {
            value = Subagents;
            return IsSubagents;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SubagentsContext PickSubagents() => IsSubagents
            ? Subagents!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Subagents' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.AppContext value) => new ChatContext((global::Phoenix.AppContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.AppContext?(ChatContext @this) => @this.App;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.AppContext? value)
        {
            App = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromApp(global::Phoenix.AppContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.ProjectUIContext value) => new ChatContext((global::Phoenix.ProjectUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.ProjectUIContext?(ChatContext @this) => @this.Project;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.ProjectUIContext? value)
        {
            Project = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromProject(global::Phoenix.ProjectUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.TraceUIContext value) => new ChatContext((global::Phoenix.TraceUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.TraceUIContext?(ChatContext @this) => @this.Trace;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.TraceUIContext? value)
        {
            Trace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromTrace(global::Phoenix.TraceUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.SessionUIContext value) => new ChatContext((global::Phoenix.SessionUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.SessionUIContext?(ChatContext @this) => @this.Session;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.SessionUIContext? value)
        {
            Session = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromSession(global::Phoenix.SessionUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.PromptUIContext value) => new ChatContext((global::Phoenix.PromptUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.PromptUIContext?(ChatContext @this) => @this.Prompt;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.PromptUIContext? value)
        {
            Prompt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromPrompt(global::Phoenix.PromptUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.PromptVersionUIContext value) => new ChatContext((global::Phoenix.PromptVersionUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.PromptVersionUIContext?(ChatContext @this) => @this.PromptVersion;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.PromptVersionUIContext? value)
        {
            PromptVersion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromPromptVersion(global::Phoenix.PromptVersionUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.SpanUIContext value) => new ChatContext((global::Phoenix.SpanUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.SpanUIContext?(ChatContext @this) => @this.Span;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.SpanUIContext? value)
        {
            Span = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromSpan(global::Phoenix.SpanUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.PlaygroundUIContext value) => new ChatContext((global::Phoenix.PlaygroundUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.PlaygroundUIContext?(ChatContext @this) => @this.Playground;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.PlaygroundUIContext? value)
        {
            Playground = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromPlayground(global::Phoenix.PlaygroundUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.CodeEvaluatorUIContext value) => new ChatContext((global::Phoenix.CodeEvaluatorUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.CodeEvaluatorUIContext?(ChatContext @this) => @this.CodeEvaluator;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.CodeEvaluatorUIContext? value)
        {
            CodeEvaluator = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromCodeEvaluator(global::Phoenix.CodeEvaluatorUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.LlmEvaluatorUIContext value) => new ChatContext((global::Phoenix.LlmEvaluatorUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.LlmEvaluatorUIContext?(ChatContext @this) => @this.LlmEvaluator;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.LlmEvaluatorUIContext? value)
        {
            LlmEvaluator = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromLlmEvaluator(global::Phoenix.LlmEvaluatorUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.DatasetUIContext value) => new ChatContext((global::Phoenix.DatasetUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.DatasetUIContext?(ChatContext @this) => @this.Dataset;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.DatasetUIContext? value)
        {
            Dataset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromDataset(global::Phoenix.DatasetUIContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.GraphQLContext value) => new ChatContext((global::Phoenix.GraphQLContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.GraphQLContext?(ChatContext @this) => @this.Graphql;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.GraphQLContext? value)
        {
            Graphql = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromGraphql(global::Phoenix.GraphQLContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.WebAccessContext value) => new ChatContext((global::Phoenix.WebAccessContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.WebAccessContext?(ChatContext @this) => @this.WebAccess;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.WebAccessContext? value)
        {
            WebAccess = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromWebAccess(global::Phoenix.WebAccessContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.SubagentsContext value) => new ChatContext((global::Phoenix.SubagentsContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.SubagentsContext?(ChatContext @this) => @this.Subagents;

        /// <summary>
        ///
        /// </summary>
        public ChatContext(global::Phoenix.SubagentsContext? value)
        {
            Subagents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContext FromSubagents(global::Phoenix.SubagentsContext? value) => new ChatContext(value);

        /// <summary>
        ///
        /// </summary>
        public ChatContext(
            global::Phoenix.ChatContextDiscriminatorType? type,
            global::Phoenix.AppContext? app,
            global::Phoenix.ProjectUIContext? project,
            global::Phoenix.TraceUIContext? trace,
            global::Phoenix.SessionUIContext? session,
            global::Phoenix.PromptUIContext? prompt,
            global::Phoenix.PromptVersionUIContext? promptVersion,
            global::Phoenix.SpanUIContext? span,
            global::Phoenix.PlaygroundUIContext? playground,
            global::Phoenix.CodeEvaluatorUIContext? codeEvaluator,
            global::Phoenix.LlmEvaluatorUIContext? llmEvaluator,
            global::Phoenix.DatasetUIContext? dataset,
            global::Phoenix.GraphQLContext? graphql,
            global::Phoenix.WebAccessContext? webAccess,
            global::Phoenix.SubagentsContext? subagents
            )
        {
            Type = type;

            App = app;
            Project = project;
            Trace = trace;
            Session = session;
            Prompt = prompt;
            PromptVersion = promptVersion;
            Span = span;
            Playground = playground;
            CodeEvaluator = codeEvaluator;
            LlmEvaluator = llmEvaluator;
            Dataset = dataset;
            Graphql = graphql;
            WebAccess = webAccess;
            Subagents = subagents;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Subagents as object ??
            WebAccess as object ??
            Graphql as object ??
            Dataset as object ??
            LlmEvaluator as object ??
            CodeEvaluator as object ??
            Playground as object ??
            Span as object ??
            PromptVersion as object ??
            Prompt as object ??
            Session as object ??
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
            Session?.ToString() ??
            Prompt?.ToString() ??
            PromptVersion?.ToString() ??
            Span?.ToString() ??
            Playground?.ToString() ??
            CodeEvaluator?.ToString() ??
            LlmEvaluator?.ToString() ??
            Dataset?.ToString() ??
            Graphql?.ToString() ??
            WebAccess?.ToString() ??
            Subagents?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && IsDataset && !IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && IsGraphql && !IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && IsWebAccess && !IsSubagents || !IsApp && !IsProject && !IsTrace && !IsSession && !IsPrompt && !IsPromptVersion && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess && IsSubagents;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.AppContext, TResult>? app = null,
            global::System.Func<global::Phoenix.ProjectUIContext, TResult>? project = null,
            global::System.Func<global::Phoenix.TraceUIContext, TResult>? trace = null,
            global::System.Func<global::Phoenix.SessionUIContext, TResult>? session = null,
            global::System.Func<global::Phoenix.PromptUIContext, TResult>? prompt = null,
            global::System.Func<global::Phoenix.PromptVersionUIContext, TResult>? promptVersion = null,
            global::System.Func<global::Phoenix.SpanUIContext, TResult>? span = null,
            global::System.Func<global::Phoenix.PlaygroundUIContext, TResult>? playground = null,
            global::System.Func<global::Phoenix.CodeEvaluatorUIContext, TResult>? codeEvaluator = null,
            global::System.Func<global::Phoenix.LlmEvaluatorUIContext, TResult>? llmEvaluator = null,
            global::System.Func<global::Phoenix.DatasetUIContext, TResult>? dataset = null,
            global::System.Func<global::Phoenix.GraphQLContext, TResult>? graphql = null,
            global::System.Func<global::Phoenix.WebAccessContext, TResult>? webAccess = null,
            global::System.Func<global::Phoenix.SubagentsContext, TResult>? subagents = null,
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
            else if (IsSession && session != null)
            {
                return session(Session!);
            }
            else if (IsPrompt && prompt != null)
            {
                return prompt(Prompt!);
            }
            else if (IsPromptVersion && promptVersion != null)
            {
                return promptVersion(PromptVersion!);
            }
            else if (IsSpan && span != null)
            {
                return span(Span!);
            }
            else if (IsPlayground && playground != null)
            {
                return playground(Playground!);
            }
            else if (IsCodeEvaluator && codeEvaluator != null)
            {
                return codeEvaluator(CodeEvaluator!);
            }
            else if (IsLlmEvaluator && llmEvaluator != null)
            {
                return llmEvaluator(LlmEvaluator!);
            }
            else if (IsDataset && dataset != null)
            {
                return dataset(Dataset!);
            }
            else if (IsGraphql && graphql != null)
            {
                return graphql(Graphql!);
            }
            else if (IsWebAccess && webAccess != null)
            {
                return webAccess(WebAccess!);
            }
            else if (IsSubagents && subagents != null)
            {
                return subagents(Subagents!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.AppContext>? app = null,

            global::System.Action<global::Phoenix.ProjectUIContext>? project = null,

            global::System.Action<global::Phoenix.TraceUIContext>? trace = null,

            global::System.Action<global::Phoenix.SessionUIContext>? session = null,

            global::System.Action<global::Phoenix.PromptUIContext>? prompt = null,

            global::System.Action<global::Phoenix.PromptVersionUIContext>? promptVersion = null,

            global::System.Action<global::Phoenix.SpanUIContext>? span = null,

            global::System.Action<global::Phoenix.PlaygroundUIContext>? playground = null,

            global::System.Action<global::Phoenix.CodeEvaluatorUIContext>? codeEvaluator = null,

            global::System.Action<global::Phoenix.LlmEvaluatorUIContext>? llmEvaluator = null,

            global::System.Action<global::Phoenix.DatasetUIContext>? dataset = null,

            global::System.Action<global::Phoenix.GraphQLContext>? graphql = null,

            global::System.Action<global::Phoenix.WebAccessContext>? webAccess = null,

            global::System.Action<global::Phoenix.SubagentsContext>? subagents = null,
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
            else if (IsSession)
            {
                session?.Invoke(Session!);
            }
            else if (IsPrompt)
            {
                prompt?.Invoke(Prompt!);
            }
            else if (IsPromptVersion)
            {
                promptVersion?.Invoke(PromptVersion!);
            }
            else if (IsSpan)
            {
                span?.Invoke(Span!);
            }
            else if (IsPlayground)
            {
                playground?.Invoke(Playground!);
            }
            else if (IsCodeEvaluator)
            {
                codeEvaluator?.Invoke(CodeEvaluator!);
            }
            else if (IsLlmEvaluator)
            {
                llmEvaluator?.Invoke(LlmEvaluator!);
            }
            else if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
            else if (IsGraphql)
            {
                graphql?.Invoke(Graphql!);
            }
            else if (IsWebAccess)
            {
                webAccess?.Invoke(WebAccess!);
            }
            else if (IsSubagents)
            {
                subagents?.Invoke(Subagents!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.AppContext>? app = null,
            global::System.Action<global::Phoenix.ProjectUIContext>? project = null,
            global::System.Action<global::Phoenix.TraceUIContext>? trace = null,
            global::System.Action<global::Phoenix.SessionUIContext>? session = null,
            global::System.Action<global::Phoenix.PromptUIContext>? prompt = null,
            global::System.Action<global::Phoenix.PromptVersionUIContext>? promptVersion = null,
            global::System.Action<global::Phoenix.SpanUIContext>? span = null,
            global::System.Action<global::Phoenix.PlaygroundUIContext>? playground = null,
            global::System.Action<global::Phoenix.CodeEvaluatorUIContext>? codeEvaluator = null,
            global::System.Action<global::Phoenix.LlmEvaluatorUIContext>? llmEvaluator = null,
            global::System.Action<global::Phoenix.DatasetUIContext>? dataset = null,
            global::System.Action<global::Phoenix.GraphQLContext>? graphql = null,
            global::System.Action<global::Phoenix.WebAccessContext>? webAccess = null,
            global::System.Action<global::Phoenix.SubagentsContext>? subagents = null,
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
            else if (IsSession)
            {
                session?.Invoke(Session!);
            }
            else if (IsPrompt)
            {
                prompt?.Invoke(Prompt!);
            }
            else if (IsPromptVersion)
            {
                promptVersion?.Invoke(PromptVersion!);
            }
            else if (IsSpan)
            {
                span?.Invoke(Span!);
            }
            else if (IsPlayground)
            {
                playground?.Invoke(Playground!);
            }
            else if (IsCodeEvaluator)
            {
                codeEvaluator?.Invoke(CodeEvaluator!);
            }
            else if (IsLlmEvaluator)
            {
                llmEvaluator?.Invoke(LlmEvaluator!);
            }
            else if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
            else if (IsGraphql)
            {
                graphql?.Invoke(Graphql!);
            }
            else if (IsWebAccess)
            {
                webAccess?.Invoke(WebAccess!);
            }
            else if (IsSubagents)
            {
                subagents?.Invoke(Subagents!);
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
                typeof(global::Phoenix.ProjectUIContext),
                Trace,
                typeof(global::Phoenix.TraceUIContext),
                Session,
                typeof(global::Phoenix.SessionUIContext),
                Prompt,
                typeof(global::Phoenix.PromptUIContext),
                PromptVersion,
                typeof(global::Phoenix.PromptVersionUIContext),
                Span,
                typeof(global::Phoenix.SpanUIContext),
                Playground,
                typeof(global::Phoenix.PlaygroundUIContext),
                CodeEvaluator,
                typeof(global::Phoenix.CodeEvaluatorUIContext),
                LlmEvaluator,
                typeof(global::Phoenix.LlmEvaluatorUIContext),
                Dataset,
                typeof(global::Phoenix.DatasetUIContext),
                Graphql,
                typeof(global::Phoenix.GraphQLContext),
                WebAccess,
                typeof(global::Phoenix.WebAccessContext),
                Subagents,
                typeof(global::Phoenix.SubagentsContext),
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
        public bool Equals(ChatContext other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.AppContext?>.Default.Equals(App, other.App) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ProjectUIContext?>.Default.Equals(Project, other.Project) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.TraceUIContext?>.Default.Equals(Trace, other.Trace) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.SessionUIContext?>.Default.Equals(Session, other.Session) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptUIContext?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptVersionUIContext?>.Default.Equals(PromptVersion, other.PromptVersion) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.SpanUIContext?>.Default.Equals(Span, other.Span) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PlaygroundUIContext?>.Default.Equals(Playground, other.Playground) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.CodeEvaluatorUIContext?>.Default.Equals(CodeEvaluator, other.CodeEvaluator) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LlmEvaluatorUIContext?>.Default.Equals(LlmEvaluator, other.LlmEvaluator) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.DatasetUIContext?>.Default.Equals(Dataset, other.Dataset) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.GraphQLContext?>.Default.Equals(Graphql, other.Graphql) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.WebAccessContext?>.Default.Equals(WebAccess, other.WebAccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.SubagentsContext?>.Default.Equals(Subagents, other.Subagents)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChatContext obj1, ChatContext obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContext>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatContext obj1, ChatContext obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContext o && Equals(o);
        }
    }
}
