using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class MonthlyWage
    {

        
        public int wage_hour = 20;
        public int FullTImeHour = 8;
        public int PartTImeHour = 4;
        public const int FullTime = 1;
        public const int Absent = 0;
        public const int Parttime = 2;
        public int Max_Day = 20;


        public int GenearteDigits()
        {
            return new Random().Next(0, 3);
        }


        public void MONTHLYWAGE()
        {

            int wage = 0;
            int daynumber = 1;
            while(daynumber <= Max_Day)
            {
              
                
                switch (GenearteDigits())
                {
                    case Absent:
                        

                        break;

                    case Parttime:
                        int Pwage = wage_hour * PartTImeHour;
                        wage += Pwage;
                        break;

                    case FullTime:
                        int Fwage = wage_hour * FullTImeHour;
                        wage += Fwage;
                        break;

                }
                daynumber++;
            }

            Console.WriteLine("The Monthly wage is " + wage);

           
        }
    }
}