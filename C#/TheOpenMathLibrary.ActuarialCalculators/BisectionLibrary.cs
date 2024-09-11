namespace ActuarialCalculators
{
    /// <summary>
    /// This BisectionLibrary module in executes a computational technique referred to as the Bisection Method.
    /// </summary>
    public class BisectionLibrary
    {
        /// <summary>
        /// This method determines the root of a formula (ie: where a function reaches zero), i.e., the value of function(x) for which (f(x) = 0).
        /// </summary>
        /// <param name="valueA">The starting point of the interval.</param>
        /// <param name="valueB">The ending point of the interval.</param>
        /// <param name="tolerance">The acceptable error margin for the root.</param>
        /// <param name="maxIterations">The maximum number of iterations to perform.</param>
        /// <param name="mathFunction">The function for which the root is being sought, represented as a delegate Func<double, double>.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Bisection(double valueA, double valueB, double tolerance, int maxIterations, Func<double, double> mathFunction)
        {
            double functionA = mathFunction(valueA);
            double functionB = mathFunction(valueB);
            if (functionA * functionB > 0)
            {
                throw new ArgumentException("function(a) and function(b) must have opposite signs");
            }
            double c = 0;
            for (int i = 0; i < maxIterations; i++)
            {
                c = (valueA + valueB) / 2;
                double functionC = mathFunction(c);
                if (Math.Abs(functionC) < tolerance)
                {
                    break;
                }
                if (functionA * functionC < 0)
                {
                    valueB = c;
                    functionB = functionC;
                }
                else
                {
                    valueA = c;
                    functionA = functionC;
                }
            }
            return c;
        }

        /// <summary>
        /// Newton raphson goalseek method to find the root of a function
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="tolerance"></param>
        /// <param name="maxIterations"></param>
        /// <param name="mathFunction"></param>
        /// <param name="mathFunctionDerivative"></param>
        /// <returns></returns>
        public static double NewtonRaphson(double x0, double tolerance, int maxIterations, Func<double, double> mathFunction, Func<double, double> mathFunctionDerivative)
        {
            double x = x0;
            for (int i = 0; i < maxIterations; i++)
            {
                double functionX = mathFunction(x);
                double derivativeX = mathFunctionDerivative(x);
                double x1 = x - functionX / derivativeX;
                if (Math.Abs(x1 - x) < tolerance)
                {
                    break;
                }
                x = x1;
            }
            return x;
        }

        /// <summary>
        /// Binomial goalseek calculator to find the root of a function
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="tolerance"></param>
        /// <param name="maxIterations"></param>
        /// <param name="mathFunction"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Binomial(double valueA, double valueB, double tolerance, int maxIterations, Func<double, double> mathFunction)
        {
            double functionA = mathFunction(valueA);
            double functionB = mathFunction(valueB);
            if (functionA * functionB > 0)
            {
                throw new ArgumentException("function(a) and function(b) must have opposite signs");
            }
            double c = 0;
            for (int i = 0; i < maxIterations; i++)
            {
                c = (valueA + valueB) / 2;
                double functionC = mathFunction(c);
                if (Math.Abs(functionC) < tolerance)
                {
                    break;
                }
                if (functionA * functionC < 0)
                {
                    valueB = c;
                    functionB = functionC;
                }
                else
                {
                    valueA = c;
                    functionA = functionC;
                }
            }
            return c;
        }

    }
}
