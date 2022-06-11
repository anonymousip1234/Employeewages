using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PartTimeFullTime
    {
        public int Present = 1;
        public int wage_hour = 20;
        public int FullTImeHour = 8;
        public int PartTImeHour = 4;
        public int FullTime = 1;


        public void DAILYWAGE()
        {
            Random value = new Random();
            int binary = value.Next(0, 2);

            if (binary == Present)
            {
                Random check = new Random();
                int PTorFT = check.Next(0, 2);

                if (PTorFT == FullTime)
                    {
                    int wage = wage_hour * FullTImeHour;

                    Console.WriteLine("Employee is Present" + " Wage is " + wage);
                }
                else
                {
                    int wage = wage_hour * PartTImeHour;
                    Console.WriteLine("Employee is Present" + " Wage is " + wage);
                }
               
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
