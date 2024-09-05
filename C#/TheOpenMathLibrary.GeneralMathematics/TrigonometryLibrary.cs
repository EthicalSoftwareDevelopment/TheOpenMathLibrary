using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActuarialCalculators
{
    public class TrigonometryLibrary
    {
        public static double Sine(double x)
        {
            return Math.Sin(x);
        }

        public static double Cosine(double x)
        {
            return Math.Cos(x);
        }

        public static double Tangent(double x)
        {
            return Math.Tan(x);
        }
  
        public static double Cotangent(double x)
        {
            return 1 / Math.Tan(x);
        }

        public static double Secant(double x)
        {
            return 1 / Math.Cos(x);
        }

        public static double Cosecant(double x)
        {
            return 1 / Math.Sin(x);
        }

        public static double Exsecant(double x)
        {
            return 1 / Math.Cos(x) - 1;
        }

        public static double Excosecant(double x)
        {
            return 1 / Math.Sin(x) - 1;
        }

        public static double Versine(double x)
        {
            return 1 - Math.Cos(x);
        }

        public static double Coversine(double x)
        {
            return 1 - Math.Sin(x);
        }

        public static double Vercosine(double x)
        {
            return 1 - Math.Cos(x);
        }

        public static double Covercosine(double x)
        {
            return 1 - Math.Sin(x);
        }

        public static double Haversine(double x)
        {
            return 0.5 * (1 - Math.Cos(x));
        }

        public static double Hacoversine(double x)
        {
            return 0.5 * (1 - Math.Sin(x));
        }

        public static double Havercosine(double x)
        {
            return 0.5 * (1 - Math.Cos(x));
        }

        public static double Hacovercosine(double x)
        {
            return 0.5 * (1 - Math.Sin(x));
        }

    }
}
