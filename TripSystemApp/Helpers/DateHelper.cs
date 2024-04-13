using System;

namespace TripSystemApp.Helpers
{
    public static class DateHelper
    {
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd"); // Example format: "2024-04-20"
        }

        public static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }

        public static bool IsValidDate(string dateString)
        {
            return DateTime.TryParse(dateString, out _);
        }
    }
}
