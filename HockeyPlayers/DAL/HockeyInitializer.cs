using HockeyPlayers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyPlayers.DAL
{
    public class HockeyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HockeyContext>
    {
        protected override void Seed(HockeyContext context)
        {
            var players = new List<Player>
            {
                new Player{LastName="Perron",FirstName="David",currentTeam="Blues",StartDate=DateTime.Parse("2007-10-07"),Position=Position.LW },
                new Player{LastName="McDavid",FirstName="Connor",currentTeam="Oilers",StartDate=DateTime.Parse("2014-10-13"),Position=Position.C },
                new Player{LastName="MacKinnon",FirstName="Nathan",currentTeam="Avalanche",StartDate=DateTime.Parse("2015-10-07"),Position=Position.C },
                new Player{LastName="Parayko",FirstName="Colton",currentTeam="Blues",StartDate=DateTime.Parse("2016-11-07"),Position=Position.RD },
                new Player{LastName="Quick",FirstName="Jonathan",currentTeam="Kings",StartDate=DateTime.Parse("2007-12-07"),Position=Position.G },
                new Player{LastName="Crosby",FirstName="Sidney",currentTeam="Penguins",StartDate=DateTime.Parse("2011-10-04"),Position=Position.C },
                new Player{LastName="Stamkos",FirstName="Steven",currentTeam="Lightning",StartDate=DateTime.Parse("2017-10-07"),Position=Position.C },
                new Player{LastName="Matthews",FirstName="Auston",currentTeam="Maple Leafs",StartDate=DateTime.Parse("2019-12-07"),Position=Position.C },
                new Player{LastName="Panarin",FirstName="Artemi",currentTeam="Rangers",StartDate=DateTime.Parse("2013-10-01"),Position=Position.LW },
                new Player{LastName="Tavares",FirstName="John",currentTeam="Maple Leafs",StartDate=DateTime.Parse("2016-01-07"),Position=Position.C }
            };
            players.ForEach(s => context.Players.Add(s));
            context.SaveChanges();
            var seasons = new List<Season>
            {
                new Season{SeasonID=1920,StartDate=DateTime.Parse("2019-10-02"),EndDate=DateTime.Parse("2020-06-10"),Champion="Unknown"},
                new Season{SeasonID=1819,StartDate=DateTime.Parse("2018-10-03"),EndDate=DateTime.Parse("2019-06-12"),Champion="Blues"},
                new Season{SeasonID=1718,StartDate=DateTime.Parse("2017-10-04"),EndDate=DateTime.Parse("2018-06-07"),Champion="Capitals"}
            };
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();
            var seasonPlayerStats = new List<SeasonPlayerStat>
            {
                new SeasonPlayerStat{PlayerID=1,SeasonID=1920,Team="Blues",GamesPlayed=82,Goals=24,Assists=35},
                new SeasonPlayerStat{PlayerID=1,SeasonID=1819,Team="Blues",GamesPlayed=64,Goals=17,Assists=28},
                new SeasonPlayerStat{PlayerID=1,SeasonID=1718,Team="Golden Knights",GamesPlayed=79,Goals=25,Assists=36},
                new SeasonPlayerStat{PlayerID=2,SeasonID=1920,Team="Oilers",GamesPlayed=82,Goals=45,Assists=56},
                new SeasonPlayerStat{PlayerID=2,SeasonID=1819,Team="Oilers",GamesPlayed=81,Goals=41,Assists=62},
                new SeasonPlayerStat{PlayerID=10,SeasonID=1920,Team="Maple Leafs",GamesPlayed=81,Goals=34,Assists=45},
                new SeasonPlayerStat{PlayerID=10,SeasonID=1819,Team="Maple Leafs",GamesPlayed=82,Goals=31,Assists=56},
                new SeasonPlayerStat{PlayerID=10,SeasonID=1718,Team="Islanders",GamesPlayed=76,Goals=37,Assists=49}
            };
            seasonPlayerStats.ForEach(s => context.SeasonPlayerStats.Add(s));
            context.SaveChanges();
;        }

    }
}