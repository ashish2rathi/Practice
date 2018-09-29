using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Security.Policy;
using Newtonsoft.Json;

namespace BloggingSite.Models
{
    public class BlogPostsRestClient
    {
        private string BASE_URL = "https://localhost:44366/api/blogposts/";

        public async Task<String> FindAll()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = await client.GetAsync(BASE_URL);

            if (responseMessage.IsSuccessStatusCode)
            {
                return responseMessage.Content.ReadAsStringAsync().Result;
            }
            return null;
        }
    }
}
