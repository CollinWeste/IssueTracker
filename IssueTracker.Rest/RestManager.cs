using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Rest
{
    public class RestManager
    {
        private readonly HttpClient _httpClient;

        public RestManager(Uri baseUri)
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = baseUri
            };
        }
        
        public async Task<T> GetContentAsync<T>(string path)
        {
            T result = default(T);
            var response = await _httpClient.GetAsync(path);
            if (!response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<T>();
            }
            return result;
        }
    }
}
