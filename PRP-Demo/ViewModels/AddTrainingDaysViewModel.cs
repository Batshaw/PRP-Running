using PRP_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRP_Demo.ViewModels
{
    public class AddTrainingDaysViewModel
    {
        public int? Id { get; set; }

        [Required]
        [Display(Name = "Select training type")]
        public byte TrainingTypeId { get; set; }

        [Required]
        [Display(Name = "Select training day")]
        public byte DateOfWeekId { get; set; }

        public IEnumerable<DateOfWeek> DateOfWeeks { get; set; }

        public IEnumerable<TrainingType> TrainingTypes { get; set; }

        //[Required]
        public TrainingPlan TrainingPlan { get; set; }
        public int TrainingPlanId { get; set; }

        [Display(Name = "Hour: ")]
        public byte Hour10k { get; set; }

        [Display(Name = "Min: ")]
        public byte Min10k { get; set; }

        [Display(Name = "Sec: ")]
        public byte Sec10k { get; set; }

        [Required]
        public byte LastRaceDistance { get; set; }

        public AddTrainingDaysViewModel()
        {
            Hour10k = 0;
            Min10k = 0;
            Sec10k = 0;
        }

    }
}