using PRP_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRP_Demo.ViewModels
{
    public class PlanDetailViewModel
    {
        public TrainingPlan TrainingPlan { get; set; }
        public IEnumerable<TrainingDay> TrainingDays { get; set; }
    }
}