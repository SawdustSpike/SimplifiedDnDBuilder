using Newtonsoft.Json.Linq;
using System;

namespace Simple_DnD_Builder
{
    public static class HttpHelper
    {
        public static JObject Helper(string data, string index)
        {
            HttpClient client = new HttpClient();
            var url = $"https://www.dnd5eapi.co/api/{data}/{index}";
            var response = client.GetStringAsync(url).Result;
            return JObject.Parse(response);
        }
       
    }
}
