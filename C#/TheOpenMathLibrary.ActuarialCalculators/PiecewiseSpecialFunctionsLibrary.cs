using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActuarialCalculators
{
    public class PiecewiseSpecialFunctionsLibrary
    {

        public static double IndicatorFunction(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public static double StepFunction(double x)
        {
            if (x < 0)
            {
                return 0;
            }
            else if (x == 0)
            {
                return 0.5;
            }
            else
            {
                return 1;
            }
        }


        public static double HeavisideStepFunction(double x)
        {
            if (x < 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static double RectangularFunction(double x)
        {
            if (x < -0.5 || x > 0.5)
            {
                return 0;
            }
            else if (x == -0.5 || x == 0.5)
            {
                return 0.5;
            }
            else
            {
                return 1;
            }
        }

        public static double SawtoothFunction(double x)
        {
            return x - Math.Floor(x);
        }

        public static double TriangleWaveFunction(double x)
        {
            return 2 * Math.Abs(SawtoothFunction(x) - 0.5);
        }

        public static double SquareWaveFunction(double x)
        {
            return IndicatorFunction(SawtoothFunction(x) - 0.5);
        }

        public static double SincFunction(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return Math.Sin(x) / x;
            }
        }

        public static double DirichletKernel(double x, int N)
        {
            return Math.Sin((N + 0.5) * x) / (N * Math.Sin(0.5 * x));
        }
    }
}
