using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Phase4Section2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri("http://Phase4Section2a/Counter");
                var response = await client.SendAsync(request);
                string counter = await response.Content.ReadAsStringAsync();
                ViewData["Message"] = $"Counter value from cache: {counter}";
            }
        }
    }
}