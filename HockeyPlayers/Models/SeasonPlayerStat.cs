using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HockeyPlayers.Models
{
    public class SeasonPlayerStat
    {
        public int SeasonPlayerStatID { get; set; }
        public int PlayerID { get; set; }
        public int SeasonID { get; set; }
        public string Team { get; set; }
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points => Goals + Assists;

        public virtual Player Player { get; set; }
        public virtual Season Season { get; set; }
    }
}