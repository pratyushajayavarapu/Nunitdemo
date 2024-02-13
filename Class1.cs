using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunitdemo
{
    // PROG8041-PRATYUSHA JAYAVARAPU-8973016-LAB Mutation Testing lab 3
        namespace NUnitDemonstration
    {
        public static class Triangle
        {
            public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle) 
            
            {
                string result;
                if ((firstAngle + secondAngle + thirdAngle) == 180)// killed the mutant
                {
                    result = "The triangle is valid";
                }
                else
                {
                    result = "The triangle is NOT valid";
                }
                return result;
            }
        }
    }
}
//the end
