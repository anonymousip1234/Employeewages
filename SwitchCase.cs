using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class SwitchCase
    {

        public int Present = 1;
        public int wage_hour = 20;
        public int FullTImeHour = 8;
        public int PartTImeHour = 4;
        public const int FullTime = 1;
        public const int Absent = 0;
        public const int Parttime = 2;


        public int generateDIgits()
            {
            return new Random().Next(0,3);
        }
        
        
        
        
        public void DAILYWAGE()
        {
            

           switch(generateDIgits())
            {
                case Absent:
                    Console.WriteLine("Employee is absent");

                    break;

                case Parttime:
                    int Pwage = wage_hour * PartTImeHour;
                    Console.WriteLine("Employee is Present " + "Daily wage is " + Pwage);
                    
                    break;

                case FullTime:
                    int Fwage = wage_hour * FullTImeHour;
                    Console.WriteLine("Employee is Present " + "Daily Wage is " + Fwage);
                    break;
                    
            }
            
        }

    }
}
