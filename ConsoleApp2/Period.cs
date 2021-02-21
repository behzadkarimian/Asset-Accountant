using System;
using System.Collections.Generic;
using System.Text;

namespace AssetAccountant
{
    class Period
    {
        private DateTime StartDate;
        private DateTime EndDate;
        private int PeriodNum;

        public Period(DateTime startDate)
        {
            this.StartDate = startDate;
            this.EndDate = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));
            PeriodNum = Helper.DateToPeriondNum(startDate);
        }

        public void Display()
        {
            Console.Write(StartDate.ToString("yyyy-MM-dd") + "\t");
            Console.Write(EndDate.ToString("yyyy-MM-dd") + "\t");
            Console.WriteLine(PeriodNum.ToString());

        }


    }
}
