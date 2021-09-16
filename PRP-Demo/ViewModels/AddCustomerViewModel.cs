using PRP_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRP_Demo.ViewModels
{
    public class AddCustomerViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Fullname")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Weight (kg)")]
        public byte? WeightsInKg { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public byte GenderId { get; set; }

        public IEnumerable<Gender> Genders { get; set; }
    }
}