using PRP_Demo.Models;
using PRP_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRP_Demo.Controllers
{
    public class TrainingDayController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public TrainingDayController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult AddTrainingDayForm(int planId)
        {
            var trainingPlan = _context.TrainingPlans.SingleOrDefault(p => p.Id == planId);
            var dateOfWeeks = _context.DateOfWeeks.ToList();
            var trainingTypes = _context.TrainingTypes.ToList();
            var viewModel = new AddTrainingDaysViewModel
            {
                TrainingPlan = trainingPlan,
                DateOfWeeks = dateOfWeeks,
                TrainingTypes = trainingTypes,
                TrainingPlanId = planId
            };

            return View(viewModel);
        }

        public ActionResult Save(int pId, TrainingDay trainingDay)
        {
            var trainingPlan = _context.TrainingPlans.SingleOrDefault(p => p.Id == pId);
            trainingDay.TrainingPlan = trainingPlan;

            var totalSeconds = trainingDay.Sec10k + 60 * trainingDay.Min10k + 3600 * trainingDay.Hour10k;
            var totalSecondsPace = totalSeconds / trainingDay.LastRaceDistance;

            var results = ComputeDistanceAndTempo(trainingDay.TrainingTypeId, totalSecondsPace);
            trainingDay.DistanceInKm = (byte)results[0];
            trainingDay.TempoInMinKm = results[1];
            //var cusotmerId = trainingDay.TrainingPlan.Customer.Id;

            _context.TrainingDays.Add(trainingDay);
            _context.SaveChanges();

            return RedirectToAction("PlanDetail", "TrainingPlan", new { id = pId });
        }

        public ActionResult Delete(int dayId, int planId)
        {
            var dayInDb = _context.TrainingDays.Single(d => d.Id == dayId);

            _context.TrainingDays.Remove(dayInDb);
            _context.SaveChanges();

            return RedirectToAction("PlanDetail", "TrainingPlan", new { id = planId});
        }

        private List<int> ComputeDistanceAndTempo(byte trainingTypeId, int totalSecondsPace)
        {
            float percentage = 0;
            int distance = 0;

            switch (trainingTypeId)
            {
                case 1:
                    percentage = 60;
                    distance = 5;
                    break;
                case 2:
                    percentage = 95;
                    distance = 6;
                    break;
                case 3:
                    percentage = 80;
                    distance = 6;
                    break;
                case 4:
                    percentage = 70;
                    distance = 15;
                    break;
            }

            var tempoInSeconds = (int)(100 * totalSecondsPace / percentage);

            return new List<int>() { distance, tempoInSeconds};
        }
    }
}