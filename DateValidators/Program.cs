﻿namespace DateValidators
{

    public static class DateValidators
    {
        public static bool IsWeekend(DateTime dateTime)
            => dateTime.DayOfWeek == DayOfWeek.Saturday ||
               dateTime.DayOfWeek == DayOfWeek.Sunday;

        public static bool IsFuture(DateTime dateTime)
            => dateTime.Date > DateTime.Today;
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
           
        }
    }
}