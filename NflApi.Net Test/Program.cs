using System;
using System.Collections.Generic;
using System.Threading;

namespace NflApi.Net_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose demo to use:");
            Console.WriteLine("");
            Console.WriteLine("(1) Fantasy player schedule");
            Console.WriteLine("(2) Live play feed");
            Console.WriteLine("");
            int choose = Int32.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Clear();
            if (choose == 1)
                Schedule();
            else if (choose == 2)
                Feed();

        }
        static void Schedule()
        {
            Console.WriteLine("Enter league id:");
            string leagueid = Console.ReadLine();
            Console.Clear();
            var auth = NFL.Com.Auth.GetAuth();
            var data = NFL.Com.CurrentData.GetData(auth);
            Console.WriteLine($"Week {data.week}");
            var matches = NFL.Com.Week.GetWeek(auth, data.week, 2021);
            var fantasyteams = NFL.ESPN.Fantasy.Scoreboard.GetScore(leagueid, 2021);
            Console.WriteLine("Choose team:");
            foreach (var team in fantasyteams.teams)
            {
                Console.WriteLine($"{team.location} {team.nickname}");
            }
            int teamid = Int32.Parse(Console.ReadKey().KeyChar.ToString());
            var rosters = NFL.ESPN.Fantasy.Rosters.GetRosters(leagueid, 2021);
            var teamdata = rosters.teams.Find(o => o.id == teamid);
            var matchup = fantasyteams.schedule.Find(o => o.winner == "UNDECIDED" && (o.away.teamId == teamid || o.home.teamId == teamid));
            int oppoteam = 0;
            if (matchup.home.teamId == teamid)
            {
                oppoteam = matchup.away.teamId;
            }
            else
            {
                oppoteam = matchup.home.teamId;
            }
            var oppoteamdata = rosters.teams.Find(o => o.id == oppoteam);
            Console.Clear();
            foreach (var match in matches.games)
            {
                Console.WriteLine($"{match.awayTeam.fullName} vs. {match.homeTeam.fullName}");
                Console.WriteLine(match.time.ToLocalTime().ToString("MMMM dd hh:mm ") + TimeZoneInfo.Local.Id);
                Console.WriteLine("Your team:");
                foreach (var player in teamdata.roster.entries)
                {
                    string proteam = NFL.ESPN.Fantasy.Const.nflTeamIdToNFLTeam[player.playerPoolEntry.player.proTeamId];
                    if (proteam == match.awayTeam.fullName || proteam == match.homeTeam.fullName)
                    {
                        Console.WriteLine(player.playerPoolEntry.player.fullName);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Opposing team:");
                foreach (var player in oppoteamdata.roster.entries)
                {
                    string proteam = NFL.ESPN.Fantasy.Const.nflTeamIdToNFLTeam[player.playerPoolEntry.player.proTeamId];
                    if (proteam == match.awayTeam.fullName || proteam == match.homeTeam.fullName)
                    {
                        Console.WriteLine(player.playerPoolEntry.player.fullName);
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Feed()
        {
            Dictionary<string, int> matches = new Dictionary<string, int>();
            var auth = NFL.Com.Auth.GetAuth();
            var data = NFL.Com.CurrentData.GetData(auth);
            var week = NFL.Com.Week.GetWeek(auth, data.week, 2021);
            foreach(var game in week.games)
            {
                if(game.status == "Live" && !matches.ContainsKey(game.id))
                {
                    matches.Add(game.id, 0);
                }
            }
            if(matches.Count == 0)
            {
                return;
            }
            while(1 == 1)
            {
                var matchdata = NFL.Com.MatchesList.GetMatchs(auth, new List<string>(matches.Keys).ToArray());
                foreach(var game in matchdata.data.viewer.gameDetailsByIds)
                {
                    int i = matches[game.id];
                    while(i < game.plays.Count)
                    {
                        Console.WriteLine($"{game.visitorTeam.abbreviation} vs {game.homeTeam.abbreviation}: {game.plays[i].playDescription}");
                        i++;
                    }
                    matches[game.id] = i;
                }
                Thread.Sleep(3000);
            }
        }
    }
}
