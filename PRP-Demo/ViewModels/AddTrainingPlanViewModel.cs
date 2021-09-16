using PRP_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRP_Demo.ViewModels
{
    public class AddTrainingPlanViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        //[IsAlreadyExist]
        public string Name { get; set; }

        public bool Finished { get; set; }


        //public Customer Customer { get; set; }
        public ApplicationUser User { get; set; }

        //public int? CustomerId { get; set; }
        public string UserId { get; set; }

        public AddTrainingPlanViewModel()
        {
            Id = 0;
        }
    }
}