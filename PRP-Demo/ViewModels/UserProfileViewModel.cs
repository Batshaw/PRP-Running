using PRP_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRP_Demo.ViewModels
{
    public class UserProfileViewModel
    {
        public ApplicationUser User { get; set; }
        public List<TrainingPlan> TrainingPlans { get; set; }
    }
}