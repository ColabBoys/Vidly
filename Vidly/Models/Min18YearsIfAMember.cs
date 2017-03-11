using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //below gives us access to the containing class in this case customer so we can check the birth date with custom data annotation
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required");
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("You Must be 18 or older to subscribe to this membership.");
        }
    }
}