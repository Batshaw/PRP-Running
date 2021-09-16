using PRP_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PRP_Demo.Models
{
    public class IsAlreadyExist : ValidationAttribute
    {
        private ApplicationDbContext _context { get; set; }
        public IsAlreadyExist()
        {
            _context = new ApplicationDbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var plan = (TrainingPlan)validationContext.ObjectInstance;

            var planInDbs = _context.TrainingPlans.Include(p => p.Customer).Where(p => p.Name == plan.Name && p.Customer.Id == plan.Customer.Id).ToList();

            if (planInDbs.Count > 0)
                return new ValidationResult("This name already exists!");

            return ValidationResult.Success;
        }
    }
}