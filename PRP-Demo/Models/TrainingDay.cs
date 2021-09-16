using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRP_Demo.Models
{
    public class TrainingDay
    {
        public int Id { get; set; }
        public byte DistanceInKm { get; set; }

        public int TempoInMinKm { get; set; }

        public TrainingType TrainingType { get; set; }

        [Required]
        public byte TrainingTypeId { get; set; }

        public DateOfWeek DateOfWeek { get; set; }

        [Required]
        public byte DateOfWeekId { get; set; }

        //[Required]
        public TrainingPlan TrainingPlan { get; set; }

        [Display(Name = "Hour: ")]
        public byte Hour10k { get; set; }

        [Display(Name = "Min: ")]
        public byte Min10k { get; set; }

        [Display(Name = "Sec: ")]
        public byte Sec10k { get; set; }

        public byte LastRaceDistance { get; set; }
    }
}