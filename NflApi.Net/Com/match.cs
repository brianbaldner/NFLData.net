using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace NFL.Com
{
    public class Match
    {
        public class HomeTeam
        {
            public string abbreviation { get; set; }
            public string nickName { get; set; }
        }

        public class PossessionTeam
        {
            public string abbreviation { get; set; }
            public string nickName { get; set; }
            public Franchise franchise { get; set; }
        }

        public class ScoringSummary
        {
            public int playId { get; set; }
            public string playDescription { get; set; }
            public int patPlayId { get; set; }
            public int homeScore { get; set; }
            public int visitorScore { get; set; }
        }

        public class VisitorTeam
        {
            public string abbreviation { get; set; }
            public string nickName { get; set; }
        }

        public class Weather
        {
            public object currentFahrenheit { get; set; }
            public object location { get; set; }
            public object longDescription { get; set; }
            public string shortDescription { get; set; }
            public object currentRealFeelFahrenheit { get; set; }
        }

        public class CurrentLogo
        {
            public string url { get; set; }
        }

        public class Franchise
        {
            public CurrentLogo currentLogo { get; set; }
        }

        public class Drive
        {
            public int quarterStart { get; set; }
            public string endTransition { get; set; }
            public string endYardLine { get; set; }
            public bool endedWithScore { get; set; }
            public int firstDowns { get; set; }
            public string gameClockEnd { get; set; }
            public string gameClockStart { get; set; }
            public string howEndedDescription { get; set; }
            public string howStartedDescription { get; set; }
            public bool inside20 { get; set; }
            public int orderSequence { get; set; }
            public int playCount { get; set; }
            public int playIdEnded { get; set; }
            public int playIdStarted { get; set; }
            public int playSeqEnded { get; set; }
            public int playSeqStarted { get; set; }
            public PossessionTeam possessionTeam { get; set; }
            public int quarterEnd { get; set; }
            public object realStartTime { get; set; }
            public string startTransition { get; set; }
            public string startYardLine { get; set; }
            public string timeOfPossession { get; set; }
            public int yards { get; set; }
            public int yardsPenalized { get; set; }
        }

        public class Team
        {
            public string id { get; set; }
            public string abbreviation { get; set; }
        }

        public class GsisPlayer
        {
            public string id { get; set; }
        }

        public class PlayStat
        {
            public int statId { get; set; }
            public int yards { get; set; }
            public Team team { get; set; }
            public string playerName { get; set; }
            public GsisPlayer gsisPlayer { get; set; }
        }

        public class ScoringTeam
        {
            public string id { get; set; }
            public string abbreviation { get; set; }
            public string nickName { get; set; }
        }

        public class Play
        {
            public string clockTime { get; set; }
            public int down { get; set; }
            public int? driveNetYards { get; set; }
            public int? drivePlayCount { get; set; }
            public int? driveSequenceNumber { get; set; }
            public string driveTimeOfPossession { get; set; }
            public string endClockTime { get; set; }
            public string endYardLine { get; set; }
            public bool firstDown { get; set; }
            public bool goalToGo { get; set; }
            public bool nextPlayIsGoalToGo { get; set; }
            public string nextPlayType { get; set; }
            public double orderSequence { get; set; }
            public bool penaltyOnPlay { get; set; }
            public string playClock { get; set; }
            public bool playDeleted { get; set; }
            public string playDescription { get; set; }
            public string playDescriptionWithJerseyNumbers { get; set; }
            public int playId { get; set; }
            public object playReviewStatus { get; set; }
            public bool? isBigPlay { get; set; }
            public string playType { get; set; }
            public List<PlayStat> playStats { get; set; }
            public PossessionTeam possessionTeam { get; set; }
            public string prePlayByPlay { get; set; }
            public int quarter { get; set; }
            public bool scoringPlay { get; set; }
            public string scoringPlayType { get; set; }
            public ScoringTeam scoringTeam { get; set; }
            public string shortDescription { get; set; }
            public bool specialTeamsPlay { get; set; }
            public object stPlayType { get; set; }
            public string timeOfDay { get; set; }
            public string yardLine { get; set; }
            public int yards { get; set; }
            public int yardsToGo { get; set; }
            public object latestPlay { get; set; }
        }

        public class GameDetail
        {
            public string id { get; set; }
            public string attendance { get; set; }
            public int distance { get; set; }
            public int down { get; set; }
            public string gameClock { get; set; }
            public bool goalToGo { get; set; }
            public object homePointsOvertime { get; set; }
            public int homePointsTotal { get; set; }
            public int homePointsQ1 { get; set; }
            public int homePointsQ2 { get; set; }
            public int homePointsQ3 { get; set; }
            public int homePointsQ4 { get; set; }
            public HomeTeam homeTeam { get; set; }
            public int homeTimeoutsUsed { get; set; }
            public int homeTimeoutsRemaining { get; set; }
            public object period { get; set; }
            public string phase { get; set; }
            public bool playReview { get; set; }
            public PossessionTeam possessionTeam { get; set; }
            public bool redzone { get; set; }
            public List<ScoringSummary> scoringSummaries { get; set; }
            public string stadium { get; set; }
            public string startTime { get; set; }
            public object visitorPointsOvertime { get; set; }
            public int visitorPointsOvertimeTotal { get; set; }
            public int visitorPointsQ1 { get; set; }
            public int visitorPointsQ2 { get; set; }
            public int visitorPointsQ3 { get; set; }
            public int visitorPointsQ4 { get; set; }
            public int visitorPointsTotal { get; set; }
            public VisitorTeam visitorTeam { get; set; }
            public int visitorTimeoutsUsed { get; set; }
            public int visitorTimeoutsRemaining { get; set; }
            public int homePointsOvertimeTotal { get; set; }
            public Weather weather { get; set; }
            public object yardLine { get; set; }
            public int yardsToGo { get; set; }
            public List<Drive> drives { get; set; }
            public List<Play> plays { get; set; }
        }

        public class Viewer
        {
            public GameDetail gameDetail { get; set; }
        }

        public class Data
        {
            public Viewer viewer { get; set; }
        }
        public Data data { get; set; }
        public static Match GetMatch(Auth auth, string matchid)
        {
            var client = new RestClient($"https://api.nfl.com/v3/shield/?query=query%7Bviewer%7BgameDetail(id%3A%22{matchid}%22)%7Bid%20attendance%20distance%20down%20gameClock%20goalToGo%20homePointsOvertime%20homePointsTotal%20homePointsQ1%20homePointsQ2%20homePointsQ3%20homePointsQ4%20homeTeam%7Babbreviation%20nickName%7DhomeTimeoutsUsed%20homeTimeoutsRemaining%20period%20phase%20playReview%20possessionTeam%7Babbreviation%20nickName%7Dredzone%20scoringSummaries%7BplayId%20playDescription%20patPlayId%20homeScore%20visitorScore%7Dstadium%20startTime%20visitorPointsOvertime%20visitorPointsOvertimeTotal%20visitorPointsQ1%20visitorPointsQ2%20visitorPointsQ3%20visitorPointsQ4%20visitorPointsTotal%20visitorTeam%7Babbreviation%20nickName%7DvisitorTimeoutsUsed%20visitorTimeoutsRemaining%20homePointsOvertimeTotal%20visitorPointsOvertimeTotal%20possessionTeam%7BnickName%7Dweather%7BcurrentFahrenheit%20location%20longDescription%20shortDescription%20currentRealFeelFahrenheit%7DyardLine%20yardsToGo%20drives%7BquarterStart%20endTransition%20endYardLine%20endedWithScore%20firstDowns%20gameClockEnd%20gameClockStart%20howEndedDescription%20howStartedDescription%20inside20%20orderSequence%20playCount%20playIdEnded%20playIdStarted%20playSeqEnded%20playSeqStarted%20possessionTeam%7Babbreviation%20nickName%20franchise%7BcurrentLogo%7Burl%7D%7D%7DquarterEnd%20realStartTime%20startTransition%20startYardLine%20timeOfPossession%20yards%20yardsPenalized%7Dplays%7BclockTime%20down%20driveNetYards%20drivePlayCount%20driveSequenceNumber%20driveTimeOfPossession%20endClockTime%20endYardLine%20firstDown%20goalToGo%20nextPlayIsGoalToGo%20nextPlayType%20orderSequence%20penaltyOnPlay%20playClock%20playDeleted%20playDescription%20playDescriptionWithJerseyNumbers%20playId%20playReviewStatus%20isBigPlay%20playType%20playStats%7BstatId%20yards%20team%7Bid%20abbreviation%7DplayerName%20gsisPlayer%7Bid%7D%7DpossessionTeam%7Babbreviation%20nickName%20franchise%7BcurrentLogo%7Burl%7D%7D%7DprePlayByPlay%20quarter%20scoringPlay%20scoringPlayType%20scoringTeam%7Bid%20abbreviation%20nickName%7DshortDescription%20specialTeamsPlay%20stPlayType%20timeOfDay%20yardLine%20yards%20yardsToGo%20latestPlay%7D%7D%7D%7D&variables=null");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {auth.accessToken}");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<Match>(response.Content);
            return ret;
        }
        public static Match GetMatch(Auth auth, string[] matchid)
        {
            var client = new RestClient($"https://api.nfl.com/v3/shield/?query=query%7Bviewer%7BgameDetail(id%3A%22{JsonConvert.SerializeObject(matchid)}%22)%7Bid%20attendance%20distance%20down%20gameClock%20goalToGo%20homePointsOvertime%20homePointsTotal%20homePointsQ1%20homePointsQ2%20homePointsQ3%20homePointsQ4%20homeTeam%7Babbreviation%20nickName%7DhomeTimeoutsUsed%20homeTimeoutsRemaining%20period%20phase%20playReview%20possessionTeam%7Babbreviation%20nickName%7Dredzone%20scoringSummaries%7BplayId%20playDescription%20patPlayId%20homeScore%20visitorScore%7Dstadium%20startTime%20visitorPointsOvertime%20visitorPointsOvertimeTotal%20visitorPointsQ1%20visitorPointsQ2%20visitorPointsQ3%20visitorPointsQ4%20visitorPointsTotal%20visitorTeam%7Babbreviation%20nickName%7DvisitorTimeoutsUsed%20visitorTimeoutsRemaining%20homePointsOvertimeTotal%20visitorPointsOvertimeTotal%20possessionTeam%7BnickName%7Dweather%7BcurrentFahrenheit%20location%20longDescription%20shortDescription%20currentRealFeelFahrenheit%7DyardLine%20yardsToGo%20drives%7BquarterStart%20endTransition%20endYardLine%20endedWithScore%20firstDowns%20gameClockEnd%20gameClockStart%20howEndedDescription%20howStartedDescription%20inside20%20orderSequence%20playCount%20playIdEnded%20playIdStarted%20playSeqEnded%20playSeqStarted%20possessionTeam%7Babbreviation%20nickName%20franchise%7BcurrentLogo%7Burl%7D%7D%7DquarterEnd%20realStartTime%20startTransition%20startYardLine%20timeOfPossession%20yards%20yardsPenalized%7Dplays%7BclockTime%20down%20driveNetYards%20drivePlayCount%20driveSequenceNumber%20driveTimeOfPossession%20endClockTime%20endYardLine%20firstDown%20goalToGo%20nextPlayIsGoalToGo%20nextPlayType%20orderSequence%20penaltyOnPlay%20playClock%20playDeleted%20playDescription%20playDescriptionWithJerseyNumbers%20playId%20playReviewStatus%20isBigPlay%20playType%20playStats%7BstatId%20yards%20team%7Bid%20abbreviation%7DplayerName%20gsisPlayer%7Bid%7D%7DpossessionTeam%7Babbreviation%20nickName%20franchise%7BcurrentLogo%7Burl%7D%7D%7DprePlayByPlay%20quarter%20scoringPlay%20scoringPlayType%20scoringTeam%7Bid%20abbreviation%20nickName%7DshortDescription%20specialTeamsPlay%20stPlayType%20timeOfDay%20yardLine%20yards%20yardsToGo%20latestPlay%7D%7D%7D%7D&variables=null");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {auth.accessToken}");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<Match>(response.Content);
            return ret;
        }
    }
    public class MatchesList
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class HomeTeam
        {
            public string abbreviation { get; set; }
            public string nickName { get; set; }
        }

        public class PossessionTeam
        {
            public string abbreviation { get; set; }
            public string nickName { get; set; }
            public Franchise franchise { get; set; }
        }

        public class ScoringSummary
        {
            public int playId { get; set; }
            public string playDescription { get; set; }
            public int patPlayId { get; set; }
            public int homeScore { get; set; }
            public int visitorScore { get; set; }
        }

        public class VisitorTeam
        {
            public string abbreviation { get; set; }
            public string nickName { get; set; }
        }

        public class Weather
        {
            public object currentFahrenheit { get; set; }
            public object location { get; set; }
            public object longDescription { get; set; }
            public string shortDescription { get; set; }
            public object currentRealFeelFahrenheit { get; set; }
        }

        public class CurrentLogo
        {
            public string url { get; set; }
        }

        public class Franchise
        {
            public CurrentLogo currentLogo { get; set; }
        }

        public class Drive
        {
            public int quarterStart { get; set; }
            public string endTransition { get; set; }
            public string endYardLine { get; set; }
            public bool endedWithScore { get; set; }
            public int firstDowns { get; set; }
            public string gameClockEnd { get; set; }
            public string gameClockStart { get; set; }
            public string howEndedDescription { get; set; }
            public string howStartedDescription { get; set; }
            public bool inside20 { get; set; }
            public int orderSequence { get; set; }
            public int playCount { get; set; }
            public int playIdEnded { get; set; }
            public int playIdStarted { get; set; }
            public int playSeqEnded { get; set; }
            public int playSeqStarted { get; set; }
            public PossessionTeam possessionTeam { get; set; }
            public int quarterEnd { get; set; }
            public object realStartTime { get; set; }
            public string startTransition { get; set; }
            public string startYardLine { get; set; }
            public string timeOfPossession { get; set; }
            public int yards { get; set; }
            public int yardsPenalized { get; set; }
        }

        public class Team
        {
            public string id { get; set; }
            public string abbreviation { get; set; }
        }

        public class GsisPlayer
        {
            public string id { get; set; }
        }

        public class PlayStat
        {
            public int statId { get; set; }
            public int yards { get; set; }
            public Team team { get; set; }
            public string playerName { get; set; }
            public GsisPlayer gsisPlayer { get; set; }
        }

        public class ScoringTeam
        {
            public string id { get; set; }
            public string abbreviation { get; set; }
            public string nickName { get; set; }
        }

        public class Play
        {
            public string clockTime { get; set; }
            public int down { get; set; }
            public int? driveNetYards { get; set; }
            public int? drivePlayCount { get; set; }
            public int? driveSequenceNumber { get; set; }
            public string driveTimeOfPossession { get; set; }
            public string endClockTime { get; set; }
            public string endYardLine { get; set; }
            public bool firstDown { get; set; }
            public bool goalToGo { get; set; }
            public bool nextPlayIsGoalToGo { get; set; }
            public string nextPlayType { get; set; }
            public double orderSequence { get; set; }
            public bool penaltyOnPlay { get; set; }
            public string playClock { get; set; }
            public bool playDeleted { get; set; }
            public string playDescription { get; set; }
            public string playDescriptionWithJerseyNumbers { get; set; }
            public int playId { get; set; }
            public object playReviewStatus { get; set; }
            public bool? isBigPlay { get; set; }
            public string playType { get; set; }
            public List<PlayStat> playStats { get; set; }
            public PossessionTeam possessionTeam { get; set; }
            public string prePlayByPlay { get; set; }
            public int quarter { get; set; }
            public bool scoringPlay { get; set; }
            public string scoringPlayType { get; set; }
            public ScoringTeam scoringTeam { get; set; }
            public string shortDescription { get; set; }
            public bool specialTeamsPlay { get; set; }
            public object stPlayType { get; set; }
            public string timeOfDay { get; set; }
            public string yardLine { get; set; }
            public int yards { get; set; }
            public int yardsToGo { get; set; }
            public object latestPlay { get; set; }
        }

        public class GameDetailsById
        {
            public string id { get; set; }
            public string attendance { get; set; }
            public int distance { get; set; }
            public int down { get; set; }
            public string gameClock { get; set; }
            public bool goalToGo { get; set; }
            public object homePointsOvertime { get; set; }
            public int homePointsTotal { get; set; }
            public int homePointsQ1 { get; set; }
            public int homePointsQ2 { get; set; }
            public int homePointsQ3 { get; set; }
            public int homePointsQ4 { get; set; }
            public HomeTeam homeTeam { get; set; }
            public int homeTimeoutsUsed { get; set; }
            public int homeTimeoutsRemaining { get; set; }
            public object period { get; set; }
            public string phase { get; set; }
            public bool playReview { get; set; }
            public PossessionTeam possessionTeam { get; set; }
            public bool redzone { get; set; }
            public List<ScoringSummary> scoringSummaries { get; set; }
            public string stadium { get; set; }
            public string startTime { get; set; }
            public object visitorPointsOvertime { get; set; }
            public int visitorPointsOvertimeTotal { get; set; }
            public int visitorPointsQ1 { get; set; }
            public int visitorPointsQ2 { get; set; }
            public int visitorPointsQ3 { get; set; }
            public int visitorPointsQ4 { get; set; }
            public int visitorPointsTotal { get; set; }
            public VisitorTeam visitorTeam { get; set; }
            public int visitorTimeoutsUsed { get; set; }
            public int visitorTimeoutsRemaining { get; set; }
            public int homePointsOvertimeTotal { get; set; }
            public Weather weather { get; set; }
            public object yardLine { get; set; }
            public int yardsToGo { get; set; }
            public List<Drive> drives { get; set; }
            public List<Play> plays { get; set; }
        }

        public class Viewer
        {
            public List<GameDetailsById> gameDetailsByIds { get; set; }
        }

        public class Data
        {
            public Viewer viewer { get; set; }
        }

        public Data data { get; set; }


        public static MatchesList GetMatchs(Auth auth, string[] matchid)
        {
            var client = new RestClient($"https://api.nfl.com/v3/shield/?query=query%7Bviewer%7BgameDetailsByIds(ids%3A{JsonConvert.SerializeObject(matchid, Formatting.None)})%7Bid%20attendance%20distance%20down%20gameClock%20goalToGo%20homePointsOvertime%20homePointsTotal%20homePointsQ1%20homePointsQ2%20homePointsQ3%20homePointsQ4%20homeTeam%7Babbreviation%20nickName%7DhomeTimeoutsUsed%20homeTimeoutsRemaining%20period%20phase%20playReview%20possessionTeam%7Babbreviation%20nickName%7Dredzone%20scoringSummaries%7BplayId%20playDescription%20patPlayId%20homeScore%20visitorScore%7Dstadium%20startTime%20visitorPointsOvertime%20visitorPointsOvertimeTotal%20visitorPointsQ1%20visitorPointsQ2%20visitorPointsQ3%20visitorPointsQ4%20visitorPointsTotal%20visitorTeam%7Babbreviation%20nickName%7DvisitorTimeoutsUsed%20visitorTimeoutsRemaining%20homePointsOvertimeTotal%20visitorPointsOvertimeTotal%20possessionTeam%7BnickName%7Dweather%7BcurrentFahrenheit%20location%20longDescription%20shortDescription%20currentRealFeelFahrenheit%7DyardLine%20yardsToGo%20drives%7BquarterStart%20endTransition%20endYardLine%20endedWithScore%20firstDowns%20gameClockEnd%20gameClockStart%20howEndedDescription%20howStartedDescription%20inside20%20orderSequence%20playCount%20playIdEnded%20playIdStarted%20playSeqEnded%20playSeqStarted%20possessionTeam%7Babbreviation%20nickName%20franchise%7BcurrentLogo%7Burl%7D%7D%7DquarterEnd%20realStartTime%20startTransition%20startYardLine%20timeOfPossession%20yards%20yardsPenalized%7Dplays%7BclockTime%20down%20driveNetYards%20drivePlayCount%20driveSequenceNumber%20driveTimeOfPossession%20endClockTime%20endYardLine%20firstDown%20goalToGo%20nextPlayIsGoalToGo%20nextPlayType%20orderSequence%20penaltyOnPlay%20playClock%20playDeleted%20playDescription%20playDescriptionWithJerseyNumbers%20playId%20playReviewStatus%20isBigPlay%20playType%20playStats%7BstatId%20yards%20team%7Bid%20abbreviation%7DplayerName%20gsisPlayer%7Bid%7D%7DpossessionTeam%7Babbreviation%20nickName%20franchise%7BcurrentLogo%7Burl%7D%7D%7DprePlayByPlay%20quarter%20scoringPlay%20scoringPlayType%20scoringTeam%7Bid%20abbreviation%20nickName%7DshortDescription%20specialTeamsPlay%20stPlayType%20timeOfDay%20yardLine%20yards%20yardsToGo%20latestPlay%7D%7D%7D%7D&variables=null");
            Console.WriteLine(client.BaseUrl.AbsoluteUri);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {auth.accessToken}");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<MatchesList>(response.Content);
            return ret;
        }
    }
}
