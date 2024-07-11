using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ScientistInputModel
    {
        [Required]
        [Display(Name = "Date")]
        public string Date { get; set; }
        [Required]
        [Display(Name = "Current Field")]
        public string CurrentField { get; set; }
        [Required]
        [Display(Name = "Field Of Interest")]
        public string FieldOfInterest { get; set; }
        [Required]
        [Display(Name = "Idea Type")]
        public string IdeaType { get; set; }
        [Required]
        [Display(Name = "Field To Collaborate")]
        public string FieldToCollaborate { get; set; }
        [Required]
        [Display(Name = "Who You What To Collaborate With?")]
        public string WhomToCollabWith { get; set; }
    }
}