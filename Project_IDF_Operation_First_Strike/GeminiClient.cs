//using System.Net.Http;
//using System.Threading.Tasks;

//class GeminiClient
//{
//    private readonly string apiKey;
//    private readonly HttpClient httpClient;
//    private readonly string endpoint = "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=";


//    public GeminiClient(string apiKey)
//    {
//        this.apiKey = apiKey;
//        this.httpClient = new HttpClient();
//    }

//    public async Task<string> AskGeminiAsync(string prompt)
//    {
//        var url = endpoint + apiKey;
//        var requestBody = new
//        {
//            contents = new[]
//    {
//        new {
//            parts = new[]
//            {
//                new { text = prompt }
//            }
//        }
//    }
//        };
//    }
//}