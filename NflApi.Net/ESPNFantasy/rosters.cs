using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace NFL.ESPN.Fantasy
{
    public class Rosters
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class DraftDetail
        {
            public bool drafted { get; set; }
            public bool inProgress { get; set; }
        }



        public class Status
        {
            public long activatedDate { get; set; }
            public int createdAsLeagueType { get; set; }
            public int currentLeagueType { get; set; }
            public int currentMatchupPeriod { get; set; }
            public int finalScoringPeriod { get; set; }
            public int firstScoringPeriod { get; set; }
            public bool isActive { get; set; }
            public bool isExpired { get; set; }
            public bool isFull { get; set; }
            public bool isPlayoffMatchupEdited { get; set; }
            public bool isToBeDeleted { get; set; }
            public bool isViewable { get; set; }
            public bool isWaiverOrderEdited { get; set; }
            public int latestScoringPeriod { get; set; }
            public List<int> previousSeasons { get; set; }
            public long standingsUpdateDate { get; set; }
            public int teamsJoined { get; set; }
            public int transactionScoringPeriod { get; set; }
            public long waiverLastExecutionDate { get; set; }
            public object waiverProcessStatus { get; set; }
        }

        public class STANDARD
        {
            public int auctionValue { get; set; }
            public bool published { get; set; }
            public int rank { get; set; }
            public int rankSourceId { get; set; }
            public string rankType { get; set; }
            public int slotId { get; set; }
        }

        public class PPR
        {
            public int auctionValue { get; set; }
            public bool published { get; set; }
            public int rank { get; set; }
            public int rankSourceId { get; set; }
            public string rankType { get; set; }
            public int slotId { get; set; }
        }

        public class DraftRanksByRankType
        {
            public STANDARD STANDARD { get; set; }
            public PPR PPR { get; set; }
        }

        public class OutlooksByWeek
        {
            public string _1 { get; set; }
            public string _2 { get; set; }
            public string _3 { get; set; }
            public string _4 { get; set; }
            public string _5 { get; set; }
        }

        public class Outlooks
        {
            public OutlooksByWeek outlooksByWeek { get; set; }
        }

        public class Ownership
        {
            public double auctionValueAverage { get; set; }
            public double averageDraftPosition { get; set; }
            public double percentChange { get; set; }
            public double percentOwned { get; set; }
            public double percentStarted { get; set; }
        }




        public class Player
        {
            public bool active { get; set; }
            public int defaultPositionId { get; set; }
            public DraftRanksByRankType draftRanksByRankType { get; set; }
            public bool droppable { get; set; }
            public List<int> eligibleSlots { get; set; }
            public string firstName { get; set; }
            public string fullName { get; set; }
            public int id { get; set; }
            public bool injured { get; set; }
            public string injuryStatus { get; set; }
            public string lastName { get; set; }
            public object lastNewsDate { get; set; }
            public Outlooks outlooks { get; set; }
            public Ownership ownership { get; set; }
            public int proTeamId { get; set; }
            public string seasonOutlook { get; set; }
            public int universeId { get; set; }
            public long? lastVideoDate { get; set; }
        }


        public class PlayerPoolEntry
        {
            public double appliedStatTotal { get; set; }
            public int id { get; set; }
            public int keeperValue { get; set; }
            public int keeperValueFuture { get; set; }
            public bool lineupLocked { get; set; }
            public int onTeamId { get; set; }
            public Player player { get; set; }
            public bool rosterLocked { get; set; }
            public string status { get; set; }
            public bool tradeLocked { get; set; }
        }

        public class Entry
        {
            public object acquisitionDate { get; set; }
            public string acquisitionType { get; set; }
            public string injuryStatus { get; set; }
            public int lineupSlotId { get; set; }
            public List<string> pendingTransactionIds { get; set; }
            public int playerId { get; set; }
            public PlayerPoolEntry playerPoolEntry { get; set; }
            public string status { get; set; }
        }

        public class Roster
        {
            public double appliedStatTotal { get; set; }
            public List<Entry> entries { get; set; }
            public int tradeReservedEntries { get; set; }
        }

        public class Team
        {
            public int id { get; set; }
            public Roster roster { get; set; }
        }

        public DraftDetail draftDetail { get; set; }
        public int gameId { get; set; }
        public int id { get; set; }
        public int scoringPeriodId { get; set; }
        public int seasonId { get; set; }
        public int segmentId { get; set; }
        public Status status { get; set; }
        public List<Team> teams { get; set; }



        public static Rosters GetRosters(string leagueid, int season)
        {
            var client = new RestClient($"https://fantasy.espn.com/apis/v3/games/ffl/seasons/{season}/segments/0/leagues/{leagueid}?view=mRoster");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<Rosters>(response.Content);
            return ret;
        }
    }
}
