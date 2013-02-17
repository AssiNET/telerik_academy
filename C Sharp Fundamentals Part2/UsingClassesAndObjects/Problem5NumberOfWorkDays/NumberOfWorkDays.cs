/*
 * Write a method that calculates the number of workdays
 * between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday 
 * except a fixed list of public holidays specified preliminary as array.
 */
using System;

namespace Problem5NumberOfWorkDays
{
    class NumberOfWorkDays
    {
        static void Main(string[] args)
        {
            int workingDays = 0;
            bool isHolday = false;
            bool isWorkingWeekend = false;

            DateTime[] holidays =
            {
                new DateTime(2013, 1, 1),
                new DateTime(2013, 5, 1),
                new DateTime(2013, 5, 2),
                new DateTime(2013, 5, 3),
                new DateTime(2013, 5, 6),
                new DateTime(2013, 5, 24),
                new DateTime(2013, 9, 6),
                new DateTime(2013, 12, 24),
                new DateTime(2013, 12, 25),
                new DateTime(2013, 12, 26),
                new DateTime(2013, 12, 31)
            };

            DateTime[] workingWeekends =
            {
                new DateTime(2013, 5, 11),
                new DateTime(2013, 12, 14),
            };

            DateTime startDay = DateTime.Today;
            Console.Write("Enter date in YYYY/MM/DD format: ");
            string[] endDateAsStr = Console.ReadLine().Split('/');

            int allDays = GetWholePeriod(endDateAsStr, startDay);
            
            for (int dayNum = 1; dayNum <= allDays; dayNum++)
            {
                CheckForHolidays(startDay, holidays, ref isHolday, ref workingDays);
                CheckForWorkWeekends(startDay, workingWeekends, ref isWorkingWeekend, ref workingDays);

                startDay = startDay.AddDays(1);
            }
            Console.WriteLine(workingDays);
        }
  
        static int GetWholePeriod(string[] endDateAsStr, DateTime startDay)
        {
            int year = int.Parse(endDateAsStr[0]);
            int month = int.Parse(endDateAsStr[1]);
            int day = int.Parse(endDateAsStr[2]);

            DateTime endDate = new DateTime(year, month, day); 

            int allDays = (endDate - startDay).Days + 1;
            return allDays;
        }
  
        static int CheckForWorkWeekends(DateTime startDay, DateTime[] workingWeekends, ref bool isWorkingWeekend, ref int workingDays)
        {
            if (startDay.DayOfWeek == DayOfWeek.Saturday || startDay.DayOfWeek == DayOfWeek.Sunday)
            {
                for (int i = 0; i < workingWeekends.Length; i++)
                {
                    if (startDay == workingWeekends[i])
                    {
                        isWorkingWeekend = true;
                        break;
                    }
                }
                if (isWorkingWeekend == true)
                {
                    workingDays++;
                }
                isWorkingWeekend = false;
            }
            return workingDays;
        }
  
        static int CheckForHolidays(DateTime startDay, DateTime[] holidays, ref bool isHolday, ref int workingDays)
        {
            if (startDay.DayOfWeek != DayOfWeek.Saturday && startDay.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int holidayNum = 0; holidayNum < holidays.Length; holidayNum++)
                {
                    if (startDay == holidays[holidayNum])
                    {
                        isHolday = true;
                        break;
                    }
                }
                if (isHolday == false)
                {
                    workingDays++;
                }
                isHolday = false;
            }
            return workingDays;
        }
    }
}