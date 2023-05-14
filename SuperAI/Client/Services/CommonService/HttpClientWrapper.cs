using System.Text;

namespace SuperAI.Client.Services.CommonService
{
    public class HttpClientWrapper
    {
        private readonly HttpClient httpClient;

        public HttpClientWrapper(HttpClient? httpClient = null)
        {
            this.httpClient = httpClient ?? new HttpClient();
        }

        public void AddDefaultRequestHeader(string key, string value)
        {
            httpClient.DefaultRequestHeaders.Add(key, value);
        }

        public async Task<string?> GetAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("GET请求异常: {0}", e.Message);
                return null;
            }
        }

        public async Task<string?> PostAsync(string url, string jsonContent)
        {
            try
            {
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("POST请求异常: {0}", e.Message);
                return null;
            }
        }
    }
}
