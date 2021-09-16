using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRP_Demo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display(Name = "Fullname")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Weight (kg)")]
        public byte WeightsInKg { get; set; }

        public Gender Gender { get; set; }
        
        [Required]
        [Display(Name = "Gender")]
        public byte GenderId { get; set; }

        //public List<TrainingPlan> TrainingPlans { get; set; }

        //[Required]
        //public ApplicationUser User { get; set; }

        // TODO: Link the Customer to the User.
    }
}