using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateofBirth
{
    class Age
    {
        public static void Calculate(DateTime dateofBirth)
        {

            TimeSpan difference = DateTime.Now - dateofBirth;
            DateTime age = DateTime.MinValue.Add(difference);
            Console.WriteLine($"You are {age.Year-1} year, {age.Month-1} months, {age.Day-1} days, {age.Hour} hours, {age.Minute} minutes, {age.Second} seconds old");


            var years = difference.Days / 365;
            var months = years * 12;

            Console.WriteLine($"\n\nYou are {years} year or {months} months or {(int)difference.TotalDays} days or {(int)difference.TotalHours} hours or {(int)difference.TotalMinutes} minutes or {(int)difference.TotalSeconds} seconds old");
        }
    }
}
