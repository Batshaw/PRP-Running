using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRP_Demo.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        //[IsAlreadyExist]
        public string Name { get; set; }

        public bool Finished { get; set; }

        //[Required]
        public Customer Customer { get; set; }

        public ApplicationUser User { get; set; }
    }
}