using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActuarialCalculators
{
    public class AlgebraicLibrary
    {
        public static double Linear(double x)
        {
            return x;
        }

        public static double Cubic(double x)
        {
            return x * x * x;
        }

        public static double Quartic(double x)
        {
            return x * x * x * x;
        }

        public static double Quintic(double x)
        {
            return x * x * x * x * x;
        }

        public static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public static double CubeRoot(double x)
        {
            return Math.Cbrt(x);
        }
    }
}
