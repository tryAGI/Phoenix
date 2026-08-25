
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The SDK used to communicate with the custom provider.
    /// </summary>
    public enum CustomModelProviderSdk
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AwsBedrock,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        GoogleGenai,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomModelProviderSdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomModelProviderSdk value)
        {
            return value switch
            {
                CustomModelProviderSdk.Anthropic => "anthropic",
                CustomModelProviderSdk.AwsBedrock => "aws_bedrock",
                CustomModelProviderSdk.AzureOpenai => "azure_openai",
                CustomModelProviderSdk.GoogleGenai => "google_genai",
                CustomModelProviderSdk.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomModelProviderSdk? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CustomModelProviderSdk.Anthropic,
                "aws_bedrock" => CustomModelProviderSdk.AwsBedrock,
                "azure_openai" => CustomModelProviderSdk.AzureOpenai,
                "google_genai" => CustomModelProviderSdk.GoogleGenai,
                "openai" => CustomModelProviderSdk.Openai,
                _ => null,
            };
        }
    }
}