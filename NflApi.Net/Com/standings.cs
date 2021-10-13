using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace NFL.Com
{
    public class Standings
    {
        public class Team
        {
            public string id { get; set; }
            public string currentLogo { get; set; }
            public string fullName { get; set; }
        }

        public class Clinched
        {
            public bool bye { get; set; }
            public bool division { get; set; }
            public bool eliminated { get; set; }
            public bool homeField { get; set; }
            public bool playoff { get; set; }
            public bool wildCard { get; set; }
        }

        public class Points
        {
            public int @for { get; set; }
            public int against { get; set; }
        }

        public class Conference
        {
            public int wins { get; set; }
            public double winPct { get; set; }
            public int losses { get; set; }
            public int ties { get; set; }
            public int rank { get; set; }
            public Points points { get; set; }
        }

        public class Division
        {
            public int wins { get; set; }
            public double winPct { get; set; }
            public int losses { get; set; }
            public int ties { get; set; }
            public int rank { get; set; }
            public Points points { get; set; }
        }

        public class Home
        {
            public int wins { get; set; }
            public double winPct { get; set; }
            public int losses { get; set; }
            public int ties { get; set; }
            public Points points { get; set; }
        }

        public class Last5
        {
            public int wins { get; set; }
            public double winPct { get; set; }
            public int losses { get; set; }
            public int ties { get; set; }
            public Points points { get; set; }
        }

        public class Streak
        {
            public string type { get; set; }
            public int length { get; set; }
        }

        public class Overall
        {
            public int games { get; set; }
            public int wins { get; set; }
            public double winPct { get; set; }
            public int losses { get; set; }
            public int ties { get; set; }
            public Points points { get; set; }
            public Streak streak { get; set; }
        }

        public class Road
        {
            public int wins { get; set; }
            public double winPct { get; set; }
            public int losses { get; set; }
            public int ties { get; set; }
            public Points points { get; set; }
        }

        public class Standing
        {
            public Team team { get; set; }
            public Clinched clinched { get; set; }
            public Conference conference { get; set; }
            public Division division { get; set; }
            public Home home { get; set; }
            public Last5 last5 { get; set; }
            public Overall overall { get; set; }
            public Road road { get; set; }
        }

        public class Week
        {
            public int week { get; set; }
            public List<Standing> standings { get; set; }
        }

        public class Pagination
        {
            public int limit { get; set; }
            public object token { get; set; }
        }

        public int season { get; set; }
        public string seasonType { get; set; }
        public List<Week> weeks { get; set; }
        public Pagination pagination { get; set; }


        public static Standings GetStandings(Auth auth, int week, int season, string seasonType = "REG")
        {
            var client = new RestClient($"https://api.nfl.com/football/v2/standings?seasonType={seasonType}&week={week}&season={season}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {auth.accessToken}");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<Standings>(response.Content);
            return ret;
        }
    }
}
