using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ModelValidation.Models
{
    public class Appointment 
    {
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        [Remote("ValidateDate", "Home")]
        public DateTime Date { get; set; }

        public bool TermsAccepted { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    List<ValidationResult> errors = new List<ValidationResult>();

        //    if (string.IsNullOrEmpty(ClientName))
        //    {
        //        errors.Add(new ValidationResult("Please enter your name"));
        //    }

        //    if (DateTime.Now > Date)
        //    {
        //        errors.Add(new ValidationResult("Please enetr a date in the future"));
        //    }

        //    if (errors.Count == 0 && ClientName == "Joe" && Date.DayOfWeek == DayOfWeek.Monday)
        //    {
        //        errors.Add(new ValidationResult("Joe cannot"));
        //    }

        //    if (!TermsAccepted)
        //    {
        //        errors.Add(new ValidationResult("Your must accept the terms"));
        //    }

        //    return errors;
        //}
    }
}