using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestSkill.Core.API.Services
{
    public class BaseApiService
    {
        protected HttpClient CreateHttpClient()
        {
            try
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return httpClient;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

      

        public async Task<HttpResponseMessage> ExecuteGetAsync(string url)
        {
            HttpClient httpClient = CreateHttpClient();
    
            Debug.WriteLine($"Execute url \n {url}");
        
            var response = await httpClient.GetAsync(url);
            Debug.WriteLine($"Resopnse result {response.StatusCode} , {response.RequestMessage} ");
            return response;
        }

    }
}
