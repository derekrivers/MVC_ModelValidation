﻿using System;
using System.ComponentModel.DataAnnotations;
using ModelValidation.Models;

namespace ModelValidation.Infrastructure
{
    public class NoJoeOnMondaysAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Appointment app = value as Appointment;

            if (app == null || string.IsNullOrEmpty(app.ClientName) || app.Date == null)
            {
                // Wrong Model type or Properties are Invalid.
                return true;
            }

            return !(app.ClientName == "Joe" && app.Date.DayOfWeek == DayOfWeek.Monday);

        }
    }
}