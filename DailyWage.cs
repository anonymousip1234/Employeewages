using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class DailyWage
    {
        public int Present = 1;
        public int wage_hour = 20;
        public int total_hour = 8;


        public void DAILYWAGE()
        {
            Random value = new Random();
            int binary = value.Next(0, 2);

            if (binary == Present)
            {
                int wage = wage_hour * total_hour;
                
                Console.WriteLine("Employee is Present" +  " Wage is " + wage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }

}
