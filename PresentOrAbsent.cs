using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PresentOrAbsent
    {

        public int Present = 1;

        public void POA()
        {
            Random value = new Random();
            int binary = value.Next(0,2);

            if (binary == Present)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

    }
}
