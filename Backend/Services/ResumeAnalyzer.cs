//using GroupDocs.Parser;
//using OpenAI.Chat;
//using OpenAI_API;

//namespace ResumeAnalyzer.Services
//{
//    public class ResumeAnalyzer
//    {
//        private readonly string _apiKey;

//        public ResumeAnalyzer(IConfiguration configuration)
//        {
//            _apiKey = configuration["OpenAI:ApiKey"]!;
//        }

//        public string ExtractText(string filePath)
//        {
//            using var parser = new Parser(filePath);
//            var text = parser.GetText();
//            return text?.ToString() ?? "";
//        }

//        public async Task<string> GetSuggestions(string resumeText)
//        {
//            ChatClient client = new(model: "gpt-4o", apiKey: _apiKey);
            
//        }
//    }
//}
