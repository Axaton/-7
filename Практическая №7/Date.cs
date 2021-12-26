using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__7
{
    class Date : Triad
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int day, int month, int year) : base(day, month, year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public static Date operator +(Date date, int increase)
        {
            date.Day += increase;
            date.Month += increase;
            date.Year += increase;

            if (date.Day > 31)
            {
                date.Month += increase;
                date.Day = date.Day - 31;
            }
            if (date.Month > 12)
            {
                date.Year += increase;
                date.Month = date.Month - 12;
            }
            return new Date(date.Day, date.Month, date.Year);
        }

        public Date AddDays(int increase)
        {
            Day += increase;
            if (Day > 31)
            {
                Month += 1;
                Day = Day - 31;
            }
            if (Month > 12)
            {
                Year += 1;
                Month = Month - 12;
            }
            return new Date(Day, Month, Year);
        }
    }
}
