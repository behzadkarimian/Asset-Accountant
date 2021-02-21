using System;
using System.Collections.Generic;

namespace AssetAccountant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FinancialYear> FinancialYearsList = new List<FinancialYear>();
            bool quitFlag = false;
            DateTime startDate =  new DateTime();

            while (startDate == DateTime.MinValue)
            {
                Console.WriteLine("PLease enter the start date in this format (yyyy-mm-dd): ");

                if (!DateTime.TryParse(Console.ReadLine(), out startDate))
                {
                    Console.WriteLine("You have entered an invalid value.");
                }
            }


            while (quitFlag == false)
            {
                FinancialYear aFinancialYear = new FinancialYear(startDate);
                FinancialYearsList.Add(aFinancialYear);

                aFinancialYear.Diplay();
                Console.WriteLine("Press any key to display the next financial year or press 'q' to quit: ");
                startDate = startDate.Month < Helper.financialYearStartMonth ? 
                    new DateTime(startDate.Year, Helper.financialYearStartMonth, 1) : new DateTime(startDate.Year + 1, Helper.financialYearStartMonth, 1);

                var input = Console.ReadKey().KeyChar;
                if (input == 'q' || input == 'Q')
                {
                    quitFlag = true;
                }

            }
        }
    }
}
