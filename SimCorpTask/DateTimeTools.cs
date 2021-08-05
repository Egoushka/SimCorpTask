using System;

namespace SimCorpTask
{
    public static class DateTimeTools
    {
        public static int GetMonthsBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            DateTime dt1 = startDate.Date, dt2 = endDate.Date;
            if (dt1 > dt2) throw new ArgumentException("Start date cannot be greater than end date");
            if (dt1 == dt2) return 0;
            
            var result = ((dt2.Year - dt1.Year) * 12)
                         + dt2.Month - dt1.Month
                         + (dt2.Day >= dt1.Day - 1 ? 0 : -1)
                         + ((dt1.Day == 1 && DateTime.DaysInMonth(dt2.Year, dt2.Month) == dt2.Day) ? 1 : 0);
            return result;
        }
    }
}