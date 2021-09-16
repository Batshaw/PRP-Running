using PRP_Demo.Models;
using PRP_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRP_Demo.Controllers
{
    public class TrainingPlanController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public TrainingPlanController()
        {
            _context = new ApplicationDbContext();
        }
        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}

        public ActionResult AddTrainingPlanForm(string id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return HttpNotFound();

            var viewModel = new AddTrainingPlanViewModel
            {
                User = user,
                UserId = id
            };

            return View(viewModel);
        }

        public ActionResult Save(string cId, TrainingPlan trainingPlan)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == cId);
            if (user == null)
                return HttpNotFound();


            if (!ModelState.IsValid)
            {
                var viewModel = new AddTrainingPlanViewModel
                {
                    User = user,
                    UserId = cId
                };
                return View("AddTrainingPlanForm", viewModel);
            }

            trainingPlan.Finished = false;
            trainingPlan.User = user;

            _context.TrainingPlans.Add(trainingPlan);
            _context.SaveChanges();

            //var trainingPlanInDb = _context.TrainingPlans
            //                    .SingleOrDefault(p => p.Customer.Id == cId && p.Name == trainingPlan.Name);

            var trainingPlanInDb = _context.TrainingPlans.OrderByDescending(p => p.Id).FirstOrDefault();

            if (trainingPlanInDb == null)
                return HttpNotFound();
            
            var trainingPlanId = trainingPlanInDb.Id;

            return RedirectToAction("AddTrainingDayForm", "TrainingDay", new { planId = trainingPlanId });
        }

        public ActionResult PlanDetail(int id)
        {
            var plan = _context.TrainingPlans.Include(p => p.User).SingleOrDefault(p => p.Id == id);
            if (plan == null)
                return HttpNotFound();

            var trainingDays = _context.TrainingDays
                                .Where(d => d.TrainingPlan.Id == id)
                                .Include(d => d.DateOfWeek)
                                .Include(d => d.TrainingType)
                                .ToList();

            var viewModel = new PlanDetailViewModel
            {
                TrainingPlan = plan,
                TrainingDays = trainingDays
            };

            return View(viewModel);
        }

        public ActionResult MarkAsDone(int planId)
        {
            var planInDb = _context.TrainingPlans.Include(p => p.User).Single(p => p.Id == planId);
            planInDb.Finished = true;

            _context.SaveChanges();

            return RedirectToAction("UserProfile", "Account", new { id = planInDb.User.Id});
        }

        public ActionResult Delete(int planId, string cId)
        {
            var planInDb = _context.TrainingPlans.Single(p => p.Id == planId);
            var daysInDb = _context.TrainingDays.Where(d => d.TrainingPlan.Id == planId).ToList();

            foreach (var day in daysInDb)
            {
                _context.TrainingDays.Remove(day);
            }
            _context.TrainingPlans.Remove(planInDb);
            _context.SaveChanges();

            return RedirectToAction("UserProfile", "Account", new { id = cId });
        }
    }
}