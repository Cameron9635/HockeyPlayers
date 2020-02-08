using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HockeyPlayers.Models
{
    public class Season
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeasonID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Champion { get; set; }
        [NotMapped]
        public string DisplaySeason { get { return string.Format("{0}-{1}", StartDate.Year, EndDate.Year); } }

        public virtual ICollection<SeasonPlayerStat> SeasonPlayerStats { get; set; }
    }
}