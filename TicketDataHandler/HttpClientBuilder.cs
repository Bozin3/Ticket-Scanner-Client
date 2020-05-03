

using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TicketDataHandler
{
    public class HttpClientBuilder
    {
        public static string BaseUrl { get; set; } = "";
        private static HttpClient httpClient;
        public static HttpClient HttpClient {
            get {
                if (httpClient == null)
                {
                    return Init();
                }
                else {
                    return httpClient;
                }
            }
            set {
                httpClient = value;
            }
        }

        public static HttpClient Init()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "config.txt");
            var url = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(File.ReadAllText(path)).Url;

            Console.WriteLine(url);
            BaseUrl = url;
            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return HttpClient;
        }
    }
}
