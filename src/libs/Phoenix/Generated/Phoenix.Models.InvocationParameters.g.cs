#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InvocationParameters : global::System.IEquatable<InvocationParameters>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptVersionInvocationParametersDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptOpenAIInvocationParameters? Openai { get; init; }
#else
        public global::Phoenix.PromptOpenAIInvocationParameters? Openai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptAzureOpenAIInvocationParameters? AzureOpenai { get; init; }
#else
        public global::Phoenix.PromptAzureOpenAIInvocationParameters? AzureOpenai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureOpenai))]
#endif
        public bool IsAzureOpenai => AzureOpenai != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptAnthropicInvocationParameters? Anthropic { get; init; }
#else
        public global::Phoenix.PromptAnthropicInvocationParameters? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptGoogleInvocationParameters? Google { get; init; }
#else
        public global::Phoenix.PromptGoogleInvocationParameters? Google { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Google))]
#endif
        public bool IsGoogle => Google != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptDeepSeekInvocationParameters? Deepseek { get; init; }
#else
        public global::Phoenix.PromptDeepSeekInvocationParameters? Deepseek { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepseek))]
#endif
        public bool IsDeepseek => Deepseek != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptXAIInvocationParameters? Xai { get; init; }
#else
        public global::Phoenix.PromptXAIInvocationParameters? Xai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Xai))]
#endif
        public bool IsXai => Xai != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptOllamaInvocationParameters? Ollama { get; init; }
#else
        public global::Phoenix.PromptOllamaInvocationParameters? Ollama { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ollama))]
#endif
        public bool IsOllama => Ollama != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptAwsInvocationParameters? Aws { get; init; }
#else
        public global::Phoenix.PromptAwsInvocationParameters? Aws { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aws))]
#endif
        public bool IsAws => Aws != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptCerebrasInvocationParameters? Cerebras { get; init; }
#else
        public global::Phoenix.PromptCerebrasInvocationParameters? Cerebras { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cerebras))]
#endif
        public bool IsCerebras => Cerebras != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptFireworksInvocationParameters? Fireworks { get; init; }
#else
        public global::Phoenix.PromptFireworksInvocationParameters? Fireworks { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fireworks))]
#endif
        public bool IsFireworks => Fireworks != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptGroqInvocationParameters? Groq { get; init; }
#else
        public global::Phoenix.PromptGroqInvocationParameters? Groq { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Groq))]
#endif
        public bool IsGroq => Groq != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptMoonshotInvocationParameters? Moonshot { get; init; }
#else
        public global::Phoenix.PromptMoonshotInvocationParameters? Moonshot { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Moonshot))]
#endif
        public bool IsMoonshot => Moonshot != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptPerplexityInvocationParameters? Perplexity { get; init; }
#else
        public global::Phoenix.PromptPerplexityInvocationParameters? Perplexity { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Perplexity))]
#endif
        public bool IsPerplexity => Perplexity != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptTogetherInvocationParameters? Together { get; init; }
#else
        public global::Phoenix.PromptTogetherInvocationParameters? Together { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Together))]
#endif
        public bool IsTogether => Together != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptOpenAIInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptOpenAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptOpenAIInvocationParameters?(InvocationParameters @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptOpenAIInvocationParameters? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptAzureOpenAIInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptAzureOpenAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptAzureOpenAIInvocationParameters?(InvocationParameters @this) => @this.AzureOpenai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptAzureOpenAIInvocationParameters? value)
        {
            AzureOpenai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptAnthropicInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptAnthropicInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptAnthropicInvocationParameters?(InvocationParameters @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptAnthropicInvocationParameters? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptGoogleInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptGoogleInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptGoogleInvocationParameters?(InvocationParameters @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptGoogleInvocationParameters? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptDeepSeekInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptDeepSeekInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptDeepSeekInvocationParameters?(InvocationParameters @this) => @this.Deepseek;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptDeepSeekInvocationParameters? value)
        {
            Deepseek = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptXAIInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptXAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptXAIInvocationParameters?(InvocationParameters @this) => @this.Xai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptXAIInvocationParameters? value)
        {
            Xai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptOllamaInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptOllamaInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptOllamaInvocationParameters?(InvocationParameters @this) => @this.Ollama;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptOllamaInvocationParameters? value)
        {
            Ollama = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptAwsInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptAwsInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptAwsInvocationParameters?(InvocationParameters @this) => @this.Aws;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptAwsInvocationParameters? value)
        {
            Aws = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptCerebrasInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptCerebrasInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptCerebrasInvocationParameters?(InvocationParameters @this) => @this.Cerebras;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptCerebrasInvocationParameters? value)
        {
            Cerebras = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptFireworksInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptFireworksInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptFireworksInvocationParameters?(InvocationParameters @this) => @this.Fireworks;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptFireworksInvocationParameters? value)
        {
            Fireworks = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptGroqInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptGroqInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptGroqInvocationParameters?(InvocationParameters @this) => @this.Groq;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptGroqInvocationParameters? value)
        {
            Groq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptMoonshotInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptMoonshotInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptMoonshotInvocationParameters?(InvocationParameters @this) => @this.Moonshot;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptMoonshotInvocationParameters? value)
        {
            Moonshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptPerplexityInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptPerplexityInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptPerplexityInvocationParameters?(InvocationParameters @this) => @this.Perplexity;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptPerplexityInvocationParameters? value)
        {
            Perplexity = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::Phoenix.PromptTogetherInvocationParameters value) => new InvocationParameters((global::Phoenix.PromptTogetherInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptTogetherInvocationParameters?(InvocationParameters @this) => @this.Together;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::Phoenix.PromptTogetherInvocationParameters? value)
        {
            Together = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(
            global::Phoenix.PromptVersionInvocationParametersDiscriminatorType? type,
            global::Phoenix.PromptOpenAIInvocationParameters? openai,
            global::Phoenix.PromptAzureOpenAIInvocationParameters? azureOpenai,
            global::Phoenix.PromptAnthropicInvocationParameters? anthropic,
            global::Phoenix.PromptGoogleInvocationParameters? google,
            global::Phoenix.PromptDeepSeekInvocationParameters? deepseek,
            global::Phoenix.PromptXAIInvocationParameters? xai,
            global::Phoenix.PromptOllamaInvocationParameters? ollama,
            global::Phoenix.PromptAwsInvocationParameters? aws,
            global::Phoenix.PromptCerebrasInvocationParameters? cerebras,
            global::Phoenix.PromptFireworksInvocationParameters? fireworks,
            global::Phoenix.PromptGroqInvocationParameters? groq,
            global::Phoenix.PromptMoonshotInvocationParameters? moonshot,
            global::Phoenix.PromptPerplexityInvocationParameters? perplexity,
            global::Phoenix.PromptTogetherInvocationParameters? together
            )
        {
            Type = type;

            Openai = openai;
            AzureOpenai = azureOpenai;
            Anthropic = anthropic;
            Google = google;
            Deepseek = deepseek;
            Xai = xai;
            Ollama = ollama;
            Aws = aws;
            Cerebras = cerebras;
            Fireworks = fireworks;
            Groq = groq;
            Moonshot = moonshot;
            Perplexity = perplexity;
            Together = together;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Together as object ??
            Perplexity as object ??
            Moonshot as object ??
            Groq as object ??
            Fireworks as object ??
            Cerebras as object ??
            Aws as object ??
            Ollama as object ??
            Xai as object ??
            Deepseek as object ??
            Google as object ??
            Anthropic as object ??
            AzureOpenai as object ??
            Openai as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Openai?.ToString() ??
            AzureOpenai?.ToString() ??
            Anthropic?.ToString() ??
            Google?.ToString() ??
            Deepseek?.ToString() ??
            Xai?.ToString() ??
            Ollama?.ToString() ??
            Aws?.ToString() ??
            Cerebras?.ToString() ??
            Fireworks?.ToString() ??
            Groq?.ToString() ??
            Moonshot?.ToString() ??
            Perplexity?.ToString() ??
            Together?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && IsTogether;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.PromptOpenAIInvocationParameters?, TResult>? openai = null,
            global::System.Func<global::Phoenix.PromptAzureOpenAIInvocationParameters?, TResult>? azureOpenai = null,
            global::System.Func<global::Phoenix.PromptAnthropicInvocationParameters?, TResult>? anthropic = null,
            global::System.Func<global::Phoenix.PromptGoogleInvocationParameters?, TResult>? google = null,
            global::System.Func<global::Phoenix.PromptDeepSeekInvocationParameters?, TResult>? deepseek = null,
            global::System.Func<global::Phoenix.PromptXAIInvocationParameters?, TResult>? xai = null,
            global::System.Func<global::Phoenix.PromptOllamaInvocationParameters?, TResult>? ollama = null,
            global::System.Func<global::Phoenix.PromptAwsInvocationParameters?, TResult>? aws = null,
            global::System.Func<global::Phoenix.PromptCerebrasInvocationParameters?, TResult>? cerebras = null,
            global::System.Func<global::Phoenix.PromptFireworksInvocationParameters?, TResult>? fireworks = null,
            global::System.Func<global::Phoenix.PromptGroqInvocationParameters?, TResult>? groq = null,
            global::System.Func<global::Phoenix.PromptMoonshotInvocationParameters?, TResult>? moonshot = null,
            global::System.Func<global::Phoenix.PromptPerplexityInvocationParameters?, TResult>? perplexity = null,
            global::System.Func<global::Phoenix.PromptTogetherInvocationParameters?, TResult>? together = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }
            else if (IsAzureOpenai && azureOpenai != null)
            {
                return azureOpenai(AzureOpenai!);
            }
            else if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
            }
            else if (IsDeepseek && deepseek != null)
            {
                return deepseek(Deepseek!);
            }
            else if (IsXai && xai != null)
            {
                return xai(Xai!);
            }
            else if (IsOllama && ollama != null)
            {
                return ollama(Ollama!);
            }
            else if (IsAws && aws != null)
            {
                return aws(Aws!);
            }
            else if (IsCerebras && cerebras != null)
            {
                return cerebras(Cerebras!);
            }
            else if (IsFireworks && fireworks != null)
            {
                return fireworks(Fireworks!);
            }
            else if (IsGroq && groq != null)
            {
                return groq(Groq!);
            }
            else if (IsMoonshot && moonshot != null)
            {
                return moonshot(Moonshot!);
            }
            else if (IsPerplexity && perplexity != null)
            {
                return perplexity(Perplexity!);
            }
            else if (IsTogether && together != null)
            {
                return together(Together!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.PromptOpenAIInvocationParameters?>? openai = null,
            global::System.Action<global::Phoenix.PromptAzureOpenAIInvocationParameters?>? azureOpenai = null,
            global::System.Action<global::Phoenix.PromptAnthropicInvocationParameters?>? anthropic = null,
            global::System.Action<global::Phoenix.PromptGoogleInvocationParameters?>? google = null,
            global::System.Action<global::Phoenix.PromptDeepSeekInvocationParameters?>? deepseek = null,
            global::System.Action<global::Phoenix.PromptXAIInvocationParameters?>? xai = null,
            global::System.Action<global::Phoenix.PromptOllamaInvocationParameters?>? ollama = null,
            global::System.Action<global::Phoenix.PromptAwsInvocationParameters?>? aws = null,
            global::System.Action<global::Phoenix.PromptCerebrasInvocationParameters?>? cerebras = null,
            global::System.Action<global::Phoenix.PromptFireworksInvocationParameters?>? fireworks = null,
            global::System.Action<global::Phoenix.PromptGroqInvocationParameters?>? groq = null,
            global::System.Action<global::Phoenix.PromptMoonshotInvocationParameters?>? moonshot = null,
            global::System.Action<global::Phoenix.PromptPerplexityInvocationParameters?>? perplexity = null,
            global::System.Action<global::Phoenix.PromptTogetherInvocationParameters?>? together = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsAzureOpenai)
            {
                azureOpenai?.Invoke(AzureOpenai!);
            }
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
            else if (IsDeepseek)
            {
                deepseek?.Invoke(Deepseek!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsOllama)
            {
                ollama?.Invoke(Ollama!);
            }
            else if (IsAws)
            {
                aws?.Invoke(Aws!);
            }
            else if (IsCerebras)
            {
                cerebras?.Invoke(Cerebras!);
            }
            else if (IsFireworks)
            {
                fireworks?.Invoke(Fireworks!);
            }
            else if (IsGroq)
            {
                groq?.Invoke(Groq!);
            }
            else if (IsMoonshot)
            {
                moonshot?.Invoke(Moonshot!);
            }
            else if (IsPerplexity)
            {
                perplexity?.Invoke(Perplexity!);
            }
            else if (IsTogether)
            {
                together?.Invoke(Together!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Openai,
                typeof(global::Phoenix.PromptOpenAIInvocationParameters),
                AzureOpenai,
                typeof(global::Phoenix.PromptAzureOpenAIInvocationParameters),
                Anthropic,
                typeof(global::Phoenix.PromptAnthropicInvocationParameters),
                Google,
                typeof(global::Phoenix.PromptGoogleInvocationParameters),
                Deepseek,
                typeof(global::Phoenix.PromptDeepSeekInvocationParameters),
                Xai,
                typeof(global::Phoenix.PromptXAIInvocationParameters),
                Ollama,
                typeof(global::Phoenix.PromptOllamaInvocationParameters),
                Aws,
                typeof(global::Phoenix.PromptAwsInvocationParameters),
                Cerebras,
                typeof(global::Phoenix.PromptCerebrasInvocationParameters),
                Fireworks,
                typeof(global::Phoenix.PromptFireworksInvocationParameters),
                Groq,
                typeof(global::Phoenix.PromptGroqInvocationParameters),
                Moonshot,
                typeof(global::Phoenix.PromptMoonshotInvocationParameters),
                Perplexity,
                typeof(global::Phoenix.PromptPerplexityInvocationParameters),
                Together,
                typeof(global::Phoenix.PromptTogetherInvocationParameters),
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
        public bool Equals(InvocationParameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptOpenAIInvocationParameters?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptAzureOpenAIInvocationParameters?>.Default.Equals(AzureOpenai, other.AzureOpenai) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptAnthropicInvocationParameters?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptGoogleInvocationParameters?>.Default.Equals(Google, other.Google) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptDeepSeekInvocationParameters?>.Default.Equals(Deepseek, other.Deepseek) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptXAIInvocationParameters?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptOllamaInvocationParameters?>.Default.Equals(Ollama, other.Ollama) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptAwsInvocationParameters?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptCerebrasInvocationParameters?>.Default.Equals(Cerebras, other.Cerebras) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptFireworksInvocationParameters?>.Default.Equals(Fireworks, other.Fireworks) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptGroqInvocationParameters?>.Default.Equals(Groq, other.Groq) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptMoonshotInvocationParameters?>.Default.Equals(Moonshot, other.Moonshot) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptPerplexityInvocationParameters?>.Default.Equals(Perplexity, other.Perplexity) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptTogetherInvocationParameters?>.Default.Equals(Together, other.Together) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InvocationParameters obj1, InvocationParameters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InvocationParameters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InvocationParameters obj1, InvocationParameters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InvocationParameters o && Equals(o);
        }
    }
}
