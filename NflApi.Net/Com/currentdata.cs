using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace NFL.Com
{
    /// <summary>
    /// Fetches data from NFL.com about the current week and season.
    /// </summary>
    public class CurrentData
    {

        public int season { get; set; }
        public string seasonType { get; set; }
        public int week { get; set; }
        public List<object> byeTeams { get; set; }
        public string dateBegin { get; set; }
        public string dateEnd { get; set; }
        public string weekType { get; set; }
        /// <summary>
        /// Fetches data from NFL.com about the current week and season.
        /// </summary>
        /// <param name="auth">Authentication from the Auth class</param>
        /// <returns></returns>
        public static CurrentData GetData(Auth auth)
        {
            var client = new RestClient($"https://api.nfl.com/football/v2/weeks/date/{DateTime.Now.ToString("yyyy-MM-dd")}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {auth.accessToken}");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<CurrentData>(response.Content);
            return ret;
        }
    }
}
