using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Text.Json;
using System.Text;
using OpenAI.Chat;

namespace ResumeAnalyzer.Services
{
    public class OpenAIService
    {
        private readonly HttpClient _httpClient;
        private readonly string _api;
        private const string apiUrl = "https://api.openai.com/v1/chat/completions";
        public OpenAIService(IConfiguration configuration)
        {
            _api = configuration["OpenAI:ApiKey"]!;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_api}");
        }
        public async Task<string> GetAIResponse(string userPrompt)
        {
            ChatClient client = new(
                                    model: "gpt-3.5-turbo",
                                    apiKey: _api
                                );
            List<ChatMessage> messages =
                                        [
                                            new SystemChatMessage("You are a helpful assistant."),
                                            new UserChatMessage(userPrompt)
                                        ];

            ChatCompletion completion = await client.CompleteChatAsync(messages);
            return completion.Content[0].Text;
        }
    }
}
