using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActuarialCalculators
{
    public class TranscendentalLibrary
    {
        public static double Exponential(double x, double power)
        {
            return Math.Pow(x, power);
        }

        public static double HyperbolicSine(double x)
        {
            return Math.Sinh(x);
        }

        public static double Logarithm(double x)
        {
            return Math.Log(x);
        }

        public static double CommonLogarithm10(double x)
        {
            return Math.Log10(x);
        }

        public static double BinaryLogarithm2(double x)
        {
            return Math.Log(x, 2);
        }
    }
}
