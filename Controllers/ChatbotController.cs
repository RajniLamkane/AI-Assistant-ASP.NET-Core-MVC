using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Markdig;

namespace ChatbotDevep.Controllers
{
    public class ChatbotController : Controller
    {

        private readonly IConfiguration _configuration;

        public ChatbotController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Chat(string userMessage)
        {
            
            if (string.IsNullOrWhiteSpace(userMessage))
            {
                ViewBag.Error = "Message cannot be empty";
                return View("Index");
            }

            string apiKey = _configuration["OpenAI:ApiKey"];

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                ViewBag.Error = "OpenAI API key is not configured.";
                return View("Index");
            }


            try
            {
                using var client = new HttpClient();

                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer",
                        apiKey
                    );

                var requestBody = new
                {
                    model = "gpt-4o-mini",

                    messages = new[]
     {
        new
        {
            role = "system",
            content = @"You are a helpful programming assistant.

Always answer in clean Markdown format.

Use:
- Headings when appropriate
- Bullet points
- Numbered lists
- Bold text for important terms
- Code blocks for programming examples
- Short paragraphs
- Tables when useful

For coding questions:
1. Explain the concept simply.
2. Provide a code example.
3. Explain the code.
4. Mention important interview points when relevant.

Keep the response clear and easy to read."
        },

        new
        {
            role = "user",
            content = userMessage
        }
    }
                };

                var json = JsonSerializer.Serialize(requestBody);

                var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                var response = await client.PostAsync(
                    "https://api.openai.com/v1/chat/completions",
                    content
                );

                var responseText =
                    await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    ViewBag.Error =
                        $"OpenAI Error {(int)response.StatusCode}: {responseText}";

                    return View("Index");
                }

                using var doc =
                    JsonDocument.Parse(responseText);

                var reply =
                    doc.RootElement
                       .GetProperty("choices")[0]
                       .GetProperty("message")
                       .GetProperty("content")
                       .GetString();

                var formattedReply = Markdown.ToHtml(reply);

                ViewBag.UserMessage = userMessage;
                ViewBag.BotReply = formattedReply;
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Exception: {ex.Message}";
            }

            return View("Index");
        }
    }
}
