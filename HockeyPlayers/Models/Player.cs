using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HockeyPlayers.Models
{
    public enum Position
    {
        LW, C, RW, LD, RD, G
    }
    public class Player
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string currentTeam { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Position Position { get; set; }
        public string Secret { get; set; }
        [NotMapped]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        [NotMapped]
        public DateTime DisplayStartDate { get { return StartDate.Date; } }

        public virtual ICollection<SeasonPlayerStat> SeasonPlayerStats { get; set; }
    }
}