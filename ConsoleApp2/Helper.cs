using System;
using System.Collections.Generic;
using System.Text;

namespace AssetAccountant
{
    static class Helper
    {
        //First month of a financial year
        public const int financialYearStartMonth = 7;
        //Number of months in a year
        public const int monthInYear = 12;

        public static int DateToPeriondNum(DateTime aDate)
        {
            return ((aDate.Month + financialYearStartMonth - 2) % monthInYear) + 1;
        }
    }
}
