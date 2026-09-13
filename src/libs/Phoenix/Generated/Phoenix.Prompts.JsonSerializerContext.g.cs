
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ModelProvider), TypeInfoPropertyName = "ModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreatePromptRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreatePromptResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreatePromptVersionRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTagData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTagData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreatePromptVersionResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptVersionTagsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptVersionsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PatchPromptRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PatchPromptResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicOutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Thinking), TypeInfoPropertyName = "Thinking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType), TypeInfoPropertyName = "PromptAnthropicInvocationParametersContentThinkingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicOutputConfigEffort), TypeInfoPropertyName = "PromptAnthropicOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay), TypeInfoPropertyName = "PromptAnthropicThinkingConfigAdaptiveDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay), TypeInfoPropertyName = "PromptAnthropicThinkingConfigEnabledDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAwsInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAwsInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptAzureOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptCerebrasInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptChatTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PromptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptDeepSeekInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptFireworksInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel), TypeInfoPropertyName = "PromptGoogleThinkingConfigThinkingLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptGroqInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageRole), TypeInfoPropertyName = "PromptMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>), TypeInfoPropertyName = "AnyOfStringIListContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContentVariant2Item), TypeInfoPropertyName = "ContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TextContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolResultContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType), TypeInfoPropertyName = "PromptMessageContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMetaInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMetaInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMetaInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptMetaInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptMoonshotInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptOllamaInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptPerplexityInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptResponseFormatJSONSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptResponseFormatJSONSchemaDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptStringTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateFormat), TypeInfoPropertyName = "PromptTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateType), TypeInfoPropertyName = "PromptTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptTogetherInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceOneOrMore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceSpecificFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceZeroOrMore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolFunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolRaw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolsItem), TypeInfoPropertyName = "ToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolDiscriminatorType), TypeInfoPropertyName = "PromptToolsToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolChoice), TypeInfoPropertyName = "ToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolChoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType), TypeInfoPropertyName = "PromptToolsToolChoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template), TypeInfoPropertyName = "Template2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType), TypeInfoPropertyName = "PromptVersionTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters), TypeInfoPropertyName = "InvocationParameters2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptZAIInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType), TypeInfoPropertyName = "PromptVersionInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "PromptVersionResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template2), TypeInfoPropertyName = "Template22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType), TypeInfoPropertyName = "PromptVersionDataTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters2), TypeInfoPropertyName = "InvocationParameters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType), TypeInfoPropertyName = "PromptVersionDataInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ResponseFormatVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "PromptVersionDataResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptXAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptZAIInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptZAIInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptZAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType), TypeInfoPropertyName = "ToolCallContentPartToolCallDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>), TypeInfoPropertyName = "AnyOfBooleanInt32DoubleStringObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ModelProvider?), TypeInfoPropertyName = "NullableModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Thinking?), TypeInfoPropertyName = "NullableThinking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType?), TypeInfoPropertyName = "NullablePromptAnthropicInvocationParametersContentThinkingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicOutputConfigEffort?), TypeInfoPropertyName = "NullablePromptAnthropicOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay?), TypeInfoPropertyName = "NullablePromptAnthropicThinkingConfigAdaptiveDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay?), TypeInfoPropertyName = "NullablePromptAnthropicThinkingConfigEnabledDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptAzureOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptCerebrasInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptDeepSeekInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptFireworksInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel?), TypeInfoPropertyName = "NullablePromptGoogleThinkingConfigThinkingLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptGroqInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageRole?), TypeInfoPropertyName = "NullablePromptMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>?), TypeInfoPropertyName = "NullableAnyOfStringIListContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContentVariant2Item?), TypeInfoPropertyName = "NullableContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullablePromptMessageContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMetaInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptMetaInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptMoonshotInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptOllamaInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptPerplexityInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateFormat?), TypeInfoPropertyName = "NullablePromptTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateType?), TypeInfoPropertyName = "NullablePromptTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptTogetherInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolDiscriminatorType?), TypeInfoPropertyName = "NullablePromptToolsToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolChoice?), TypeInfoPropertyName = "NullableToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePromptToolsToolChoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template?), TypeInfoPropertyName = "NullableTemplate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters?), TypeInfoPropertyName = "NullableInvocationParameters2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template2?), TypeInfoPropertyName = "NullableTemplate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionDataTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters2?), TypeInfoPropertyName = "NullableInvocationParameters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionDataInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionDataResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptXAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptZAIInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptZAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType?), TypeInfoPropertyName = "NullableToolCallContentPartToolCallDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanInt32DoubleStringObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptVersionTagData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptVersionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.List<object>, object>))]
    internal sealed partial class PromptsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromptsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromptsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Phoenix.JsonConverters.ThinkingJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ContentVariant2ItemJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolChoiceJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TemplateJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.InvocationParametersJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ResponseFormatVariant1JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Template2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.InvocationParameters2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ResponseFormatVariant12JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>());
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
                    typeToConvert == typeof(global::Phoenix.ModelProvider)

                    || typeToConvert == typeof(global::Phoenix.ModelProvider?)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicOutputConfigEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicOutputConfigEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay?)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay)

                    || typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay?)

                    || typeToConvert == typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel)

                    || typeToConvert == typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel?)

                    || typeToConvert == typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptMessageRole)

                    || typeToConvert == typeof(global::Phoenix.PromptMessageRole?)

                    || typeToConvert == typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptMetaInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptMetaInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptTemplateFormat)

                    || typeToConvert == typeof(global::Phoenix.PromptTemplateFormat?)

                    || typeToConvert == typeof(global::Phoenix.PromptTemplateType)

                    || typeToConvert == typeof(global::Phoenix.PromptTemplateType?)

                    || typeToConvert == typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptToolsToolDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptToolsToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.PromptZAIInvocationParametersContentReasoningEffort)

                    || typeToConvert == typeof(global::Phoenix.PromptZAIInvocationParametersContentReasoningEffort?)

                    || typeToConvert == typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType)

                    || typeToConvert == typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Phoenix.ModelProvider))
                {
                    return new global::Phoenix.JsonConverters.ModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.ModelProvider?))
                {
                    return new global::Phoenix.JsonConverters.ModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicOutputConfigEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicOutputConfigEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay?))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay?))
                {
                    return new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel))
                {
                    return new global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel?))
                {
                    return new global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMessageRole))
                {
                    return new global::Phoenix.JsonConverters.PromptMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMessageRole?))
                {
                    return new global::Phoenix.JsonConverters.PromptMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMetaInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptMetaInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMetaInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptMetaInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptTemplateFormat))
                {
                    return new global::Phoenix.JsonConverters.PromptTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptTemplateFormat?))
                {
                    return new global::Phoenix.JsonConverters.PromptTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptTemplateType))
                {
                    return new global::Phoenix.JsonConverters.PromptTemplateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptTemplateType?))
                {
                    return new global::Phoenix.JsonConverters.PromptTemplateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptToolsToolDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptToolsToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptToolsToolDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptToolsToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionTemplateDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionTemplateDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptZAIInvocationParametersContentReasoningEffort))
                {
                    return new global::Phoenix.JsonConverters.PromptZAIInvocationParametersContentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.PromptZAIInvocationParametersContentReasoningEffort?))
                {
                    return new global::Phoenix.JsonConverters.PromptZAIInvocationParametersContentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType))
                {
                    return new global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType?))
                {
                    return new global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeNullableJsonConverter();
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
                    0 => new PromptsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}