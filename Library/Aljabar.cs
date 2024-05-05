using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double d = (b * b) - (4 * a * c);

            if (d < 0)
            {
                return new double[0]; // tidak ada akar real
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double a2 = a * a;
            double b2 = 2 * a * b;
            double c2 = b * b;

            return new double[] { a2, b2, c2 };
        }
    }
}
