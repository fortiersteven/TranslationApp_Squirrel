using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace TranslationApp
{
    public static class GithubAPI
    {
        public static RestClient restClient { get; set; }

        public static ReleaseModel loadLatestRelease()
        {
            var request = new RestRequest();
            string url = "https://api.github.com/repos/fortiersteven/TranslationApp_Squirrel/releases/latest";
            restClient = new RestClient(url);

            
            ReleaseModel release = restClient.Get<ReleaseModel>(request);


            return release;



        }

    }


    public class ReleaseModel
    {
        [JsonProperty(PropertyName = "tag_name")]
        public string Tag_Name { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string Html_Url { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string ReleaseNote { get; set; }

    }
}
