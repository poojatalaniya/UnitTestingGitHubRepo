using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoojaLab2
{
    // Pooja's Applications
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            // Pooja's Applications
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)  //mutation testing(Corrected)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
