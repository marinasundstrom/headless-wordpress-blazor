using System;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Frontend
{
    public class Site
    {
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private BlogInfoModel blogInfo;

        public Site(HttpClient http, IConfiguration configuration) 
        {
            this.http = http;
            this.configuration = configuration;
        }

        public string? Title => blogInfo?.Title;

        public string? Description => blogInfo?.Description;

        public string? Url => blogInfo?.Url;

        public async Task LoadAsync() 
        {
            var wordpressUrl = configuration.GetServiceUri("app");
            blogInfo = await http.GetFromJsonAsync<BlogInfoModel>($"{wordpressUrl}/wp-json/wp/v2/bloginfo");   

            Loaded?.Invoke(this, EventArgs.Empty);         
        }

        private class BlogInfoModel
        {
            [JsonPropertyName("name")]
            public string Title { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }

        public event EventHandler Loaded;
    }
}