using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Equation
    {
        public string FindValue(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
            {
                double x1 = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 2);
                double x2 = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 2);

                return $"корни уравнения: {x1}, {x2}";
            }

            else if (D == 0)
            {
                return $"корни уравнения: {-b / 2 * a}";
            }

            else
            {
                return "корней нет";
            }
        }
    }
}
