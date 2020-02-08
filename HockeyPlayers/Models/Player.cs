using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "Currently Playing", DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        public Position Position { get; set; }
        //This can be toggled by comment to change the model of the database whenever I want to update the data on the database.
        //public Position? ChangeThisToUpdateDatabase { get; set; }
        public string Secret { get; set; }
        [NotMapped]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        [NotMapped]
        public string DisplayStartDate { get { return string.Format("{0}/{1}/{2}", StartDate.Month, StartDate.Day, StartDate.Year); } }

        public virtual ICollection<SeasonPlayerStat> SeasonPlayerStats { get; set; }
    }
}