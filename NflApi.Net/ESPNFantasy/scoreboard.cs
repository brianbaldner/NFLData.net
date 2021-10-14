using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace NFL.ESPN.Fantasy
{
    /// <summary>
    /// Gets scoreboard info from league
    /// </summary>
    public class Scoreboard
    {

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class DraftDetail
        {
            public bool drafted { get; set; }
            public bool inProgress { get; set; }
        }


        public class CumulativeScore
        {
            public int losses { get; set; }
            public object statBySlot { get; set; }
            public int ties { get; set; }
            public int wins { get; set; }
        }



        public class LastUpdateInfo
        {
        }

        public class Stats
        {
            public double? _42 { get; set; }
            public double? _43 { get; set; }
            public double? _44 { get; set; }
            public double? _45 { get; set; }
            public double? _46 { get; set; }
            public double? _47 { get; set; }
            public double? _48 { get; set; }
            public double? _49 { get; set; }
            public double? _50 { get; set; }
            public double? _51 { get; set; }
            public double? _53 { get; set; }
            public double? _54 { get; set; }
            public double? _56 { get; set; }
            public double? _57 { get; set; }
            public double? _58 { get; set; }
            public double? _60 { get; set; }
            public double? _61 { get; set; }
            public double? _62 { get; set; }
            public double? _63 { get; set; }
            public double? _67 { get; set; }
            public double? _68 { get; set; }
            public double? _71 { get; set; }
            public double? _72 { get; set; }
            public double? _73 { get; set; }
            public double? _210 { get; set; }
            public double? _23 { get; set; }
            public double? _24 { get; set; }
            public double? _25 { get; set; }
            public double? _26 { get; set; }
            public double? _27 { get; set; }
            public double? _28 { get; set; }
            public double? _29 { get; set; }
            public double? _30 { get; set; }
            public double? _31 { get; set; }
            public double? _33 { get; set; }
            public double? _34 { get; set; }
            public double? _35 { get; set; }
            public double? _36 { get; set; }
            public double? _37 { get; set; }
            public double? _38 { get; set; }
            public double? _39 { get; set; }
            public double? _40 { get; set; }
            public double? _66 { get; set; }
            public double? _70 { get; set; }
            public double? _0 { get; set; }
            public double? _1 { get; set; }
            public double? _2 { get; set; }
            public double? _3 { get; set; }
            public double? _4 { get; set; }
            public double? _5 { get; set; }
            public double? _6 { get; set; }
            public double? _7 { get; set; }
            public double? _8 { get; set; }
            public double? _9 { get; set; }
            public double? _10 { get; set; }
            public double? _11 { get; set; }
            public double? _12 { get; set; }
            public double? _15 { get; set; }
            public double? _16 { get; set; }
            public double? _17 { get; set; }
            public double? _18 { get; set; }
            public double? _19 { get; set; }
            public double? _20 { get; set; }
            public double? _21 { get; set; }
            public double? _22 { get; set; }
            public double? _64 { get; set; }
            public double? _65 { get; set; }
            public double? _69 { get; set; }
            public double? _89 { get; set; }
            public double? _90 { get; set; }
            public double? _91 { get; set; }
            public double? _92 { get; set; }
            public double? _93 { get; set; }
            public double? _94 { get; set; }
            public double? _95 { get; set; }
            public double? _96 { get; set; }
            public double? _97 { get; set; }
            public double? _98 { get; set; }
            public double? _99 { get; set; }
            public double? _100 { get; set; }
            public double? _101 { get; set; }
            public double? _102 { get; set; }
            public double? _103 { get; set; }
            public double? _104 { get; set; }
            public double? _105 { get; set; }
            public double? _106 { get; set; }
            public double? _109 { get; set; }
            public double? _110 { get; set; }
            public double? _111 { get; set; }
            public double? _113 { get; set; }
            public double? _114 { get; set; }
            public double? _115 { get; set; }
            public double? _116 { get; set; }
            public double? _117 { get; set; }
            public double? _118 { get; set; }
            public double? _120 { get; set; }
            public double? _121 { get; set; }
            public double? _122 { get; set; }
            public double? _123 { get; set; }
            public double? _124 { get; set; }
            public double? _125 { get; set; }
            public double? _126 { get; set; }
            public double? _127 { get; set; }
            public double? _129 { get; set; }
            public double? _130 { get; set; }
            public double? _131 { get; set; }
            public double? _132 { get; set; }
            public double? _133 { get; set; }
            public double? _134 { get; set; }
            public double? _135 { get; set; }
            public double? _136 { get; set; }
            public double? _137 { get; set; }
            public double? _160 { get; set; }
            public double? _74 { get; set; }
            public double? _75 { get; set; }
            public double? _76 { get; set; }
            public double? _77 { get; set; }
            public double? _78 { get; set; }
            public double? _79 { get; set; }
            public double? _80 { get; set; }
            public double? _81 { get; set; }
            public double? _82 { get; set; }
            public double? _83 { get; set; }
            public double? _84 { get; set; }
            public double? _85 { get; set; }
            public double? _86 { get; set; }
            public double? _87 { get; set; }
            public double? _88 { get; set; }
            public double? _198 { get; set; }
            public double? _199 { get; set; }
            public double? _200 { get; set; }
            public double appliedTotal { get; set; }
            public double appliedTotalCeiling { get; set; }
            public string externalId { get; set; }
            public string id { get; set; }
            public LastUpdateInfo lastUpdateInfo { get; set; }
            public int proTeamId { get; set; }
            public int scoringPeriodId { get; set; }
            public int seasonId { get; set; }
            public int statSourceId { get; set; }
            public int statSplitTypeId { get; set; }
            public Stats stats { get; set; }
            public Variance variance { get; set; }
        }

        public class Variance
        {
            public double _23 { get; set; }
            public double _24 { get; set; }
            public double _25 { get; set; }
            public double _26 { get; set; }
            public double _35 { get; set; }
            public double _36 { get; set; }
            public double _42 { get; set; }
            public double _43 { get; set; }
            public double _44 { get; set; }
            public double _45 { get; set; }
            public double _46 { get; set; }
            public double _58 { get; set; }
            public double _63 { get; set; }
            public double _68 { get; set; }
            public double _72 { get; set; }
            public double? _53 { get; set; }
            public double? _0 { get; set; }
            public double? _1 { get; set; }
            public double? _3 { get; set; }
            public double? _4 { get; set; }
            public double? _15 { get; set; }
            public double? _16 { get; set; }
            public double? _19 { get; set; }
            public double? _20 { get; set; }
            public double? _64 { get; set; }
            public double? _93 { get; set; }
            public double? _94 { get; set; }
            public double? _95 { get; set; }
            public double? _96 { get; set; }
            public double? _97 { get; set; }
            public double? _98 { get; set; }
            public double? _99 { get; set; }
            public double? _103 { get; set; }
            public double? _104 { get; set; }
            public double? _106 { get; set; }
            public double? _113 { get; set; }
            public double? _114 { get; set; }
            public double? _115 { get; set; }
            public double? _120 { get; set; }
            public double? _127 { get; set; }
            public double? _74 { get; set; }
            public double? _75 { get; set; }
            public double? _76 { get; set; }
            public double? _77 { get; set; }
            public double? _78 { get; set; }
            public double? _79 { get; set; }
            public double? _80 { get; set; }
            public double? _81 { get; set; }
            public double? _82 { get; set; }
            public double? _83 { get; set; }
            public double? _84 { get; set; }
            public double? _85 { get; set; }
            public double? _86 { get; set; }
            public double? _87 { get; set; }
            public double? _88 { get; set; }
            public double? _198 { get; set; }
            public double? _199 { get; set; }
            public double? _200 { get; set; }
            public double? _101 { get; set; }
            public double? _102 { get; set; }
        }

        public class Player
        {
            public bool active { get; set; }
            public int defaultPositionId { get; set; }
            public List<int> eligibleSlots { get; set; }
            public string firstName { get; set; }
            public string fullName { get; set; }
            public int id { get; set; }
            public bool injured { get; set; }
            public string injuryStatus { get; set; }
            public string jersey { get; set; }
            public string lastName { get; set; }
            public int proTeamId { get; set; }
            public object stats { get; set; }
            public int universeId { get; set; }
        }

        public class PlayerPoolEntry
        {
            public double appliedStatTotal { get; set; }
            public int id { get; set; }
            public int onTeamId { get; set; }
            public Player player { get; set; }
            public string status { get; set; }
        }

        public class Entry
        {
            public string injuryStatus { get; set; }
            public int lineupSlotId { get; set; }
            public int playerId { get; set; }
            public PlayerPoolEntry playerPoolEntry { get; set; }
            public string status { get; set; }
        }

        public class RosterForCurrentScoringPeriod
        {
            public List<Entry> entries { get; set; }
        }

        public class RosterForMatchupPeriod
        {
            public List<object> entries { get; set; }
        }

        public class Away
        {
            public CumulativeScore cumulativeScore { get; set; }
            public int teamId { get; set; }
            public double tiebreak { get; set; }
            public double totalPoints { get; set; }
            public RosterForCurrentScoringPeriod rosterForCurrentScoringPeriod { get; set; }
            public RosterForMatchupPeriod rosterForMatchupPeriod { get; set; }
            public double? totalPointsLive { get; set; }
            public double? totalProjectedPointsLive { get; set; }
        }

        public class Home
        {
            public CumulativeScore cumulativeScore { get; set; }
            public int teamId { get; set; }
            public double tiebreak { get; set; }
            public double totalPoints { get; set; }
            public RosterForCurrentScoringPeriod rosterForCurrentScoringPeriod { get; set; }
            public RosterForMatchupPeriod rosterForMatchupPeriod { get; set; }
            public double? totalPointsLive { get; set; }
            public double? totalProjectedPointsLive { get; set; }
        }

        public class Schedule
        {
            public Away away { get; set; }
            public Home home { get; set; }
            public int id { get; set; }
            public string winner { get; set; }
        }

        public class Division
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class MatchupPeriods
        {
            public List<int> _1 { get; set; }
            public List<int> _2 { get; set; }
            public List<int> _3 { get; set; }
            public List<int> _4 { get; set; }
            public List<int> _5 { get; set; }
            public List<int> _6 { get; set; }
            public List<int> _7 { get; set; }
            public List<int> _8 { get; set; }
            public List<int> _9 { get; set; }
            public List<int> _10 { get; set; }
            public List<int> _11 { get; set; }
            public List<int> _12 { get; set; }
            public List<int> _13 { get; set; }
            public List<int> _14 { get; set; }
            public List<int> _15 { get; set; }
            public List<int> _16 { get; set; }
            public List<int> _17 { get; set; }
            public List<int> _18 { get; set; }
            public List<int> _19 { get; set; }
            public List<int> _20 { get; set; }
            public List<int> _21 { get; set; }
            public List<int> _22 { get; set; }
            public List<int> _23 { get; set; }
        }

        public class ScheduleSettings
        {
            public List<Division> divisions { get; set; }
            public MatchupPeriods matchupPeriods { get; set; }
            public int periodTypeId { get; set; }
        }

        public class ScoringItem
        {
            public bool isReverseItem { get; set; }
            public double points { get; set; }
            public int statId { get; set; }
        }

        public class ScoringSettings
        {
            public List<ScoringItem> scoringItems { get; set; }
        }

        public class Settings
        {
            public bool isCustomizable { get; set; }
            public bool isPublic { get; set; }
            public ScheduleSettings scheduleSettings { get; set; }
            public ScoringSettings scoringSettings { get; set; }
        }

        public class Status
        {
            public int currentMatchupPeriod { get; set; }
            public int finalScoringPeriod { get; set; }
            public bool isActive { get; set; }
            public int latestScoringPeriod { get; set; }
        }

        public class Overall
        {
            public int losses { get; set; }
            public int ties { get; set; }
            public int wins { get; set; }
        }

        public class Record
        {
            public Overall overall { get; set; }
        }

        public class Team
        {
            public string abbrev { get; set; }
            public int divisionId { get; set; }
            public int id { get; set; }
            public string location { get; set; }
            public string logo { get; set; }
            public string nickname { get; set; }
            public int rankCalculatedFinal { get; set; }
            public Record record { get; set; }
        }

        public DraftDetail draftDetail { get; set; }
        public int id { get; set; }
        public List<Schedule> schedule { get; set; }
        public Settings settings { get; set; }
        public Status status { get; set; }
        public List<Team> teams { get; set; }


        /// <summary>
        /// Fetches scoreboard data from ESPN Fantasy.
        /// </summary>
        /// <param name="leagueid">ID of league. Found in league URL. Must be viewable to the public.</param>
        /// <param name="season">Year of season.</param>
        /// <returns></returns>
        public static Scoreboard GetScore(string leagueid, int season)
        {
            var client = new RestClient($"https://fantasy.espn.com/apis/v3/games/ffl/seasons/{season}/segments/0/leagues/{leagueid}?view=mScoreboard");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<Scoreboard>(response.Content);
            return ret;
        }
    }
}
