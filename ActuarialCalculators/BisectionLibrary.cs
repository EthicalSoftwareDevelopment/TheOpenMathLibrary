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

    }
}
