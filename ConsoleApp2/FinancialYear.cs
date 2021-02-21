using System;
using System.Collections.Generic;
using System.Text;

namespace AssetAccountant
{
    class FinancialYear
    {
        private int _daysInYear;
        private int _startYear;
        private List<Period> _periodsList;

        public FinancialYear(DateTime startDate)
        {
            _periodsList = new List<Period>();
            _startYear = startDate.Month >= Helper.financialYearStartMonth ? startDate.Year : startDate.Year - 1;
            _daysInYear = DateTime.IsLeapYear(_startYear + 1) ? 366 : 365;

            for (int period = Helper.DateToPeriondNum(startDate); period <= Helper.monthInYear; period++)
            {
                //Set day to one
                startDate = new DateTime(startDate.Year, startDate.Month, 1);
                _periodsList.Add(new Period(startDate));
                startDate = startDate.AddMonths(1);
            }
        }

        public void Diplay()
        {
            Console.WriteLine($"\nFinancial Year {_startYear}-{_startYear + 1}:");
            Console.WriteLine($"Days: {_daysInYear}");
            Console.WriteLine("Periods:");
            Console.WriteLine("Start\t\tEnd\t\tPeriod Number");
            foreach (var period in _periodsList)
            {
                period.Display();
            }
        }
    }

}
