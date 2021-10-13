using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace NFL.Com
{
    public class Week
    {
        public class HomeTeam
        {
            public string id { get; set; }
            public string currentLogo { get; set; }
            public string fullName { get; set; }
        }

        public class AwayTeam
        {
            public string id { get; set; }
            public string currentLogo { get; set; }
            public string fullName { get; set; }
        }

        public class InternationalWatchOption
        {
            public string countryCode { get; set; }
            public List<string> broadcasters { get; set; }
        }

        public class BroadcastInfo
        {
            public List<string> homeNetworkChannels { get; set; }
            public List<string> awayNetworkChannels { get; set; }
            public List<InternationalWatchOption> internationalWatchOptions { get; set; }
            public string territory { get; set; }
        }

        public class Venue
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class ExternalId
        {
            public string source { get; set; }
            public string id { get; set; }
        }

        public class Game
        {
            public string id { get; set; }
            public HomeTeam homeTeam { get; set; }
            public AwayTeam awayTeam { get; set; }
            public string category { get; set; }
            public string date { get; set; }
            public DateTime time { get; set; }
            public BroadcastInfo broadcastInfo { get; set; }
            public Venue venue { get; set; }
            public int season { get; set; }
            public string seasonType { get; set; }
            public string status { get; set; }
            public int week { get; set; }
            public string weekType { get; set; }
            public List<ExternalId> externalIds { get; set; }
            public string ticketUrl { get; set; }
        }

        public class Pagination
        {
            public int limit { get; set; }
            public object token { get; set; }
        }

        public List<Game> games { get; set; }
        public Pagination pagination { get; set; }
        public static Week GetWeek(Auth auth, int week)
        {
            var client = new RestClient($"https://api.nfl.com/football/v2/games/season/2021/seasonType/REG/week/{week}?withExternalIds=true");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {auth.accessToken}");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<Week>(response.Content);
            return ret;
        }
    }
}
