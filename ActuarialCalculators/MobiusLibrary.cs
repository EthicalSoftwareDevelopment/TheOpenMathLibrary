using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActuarialCalculators
{
    /// <summary>
    /// This MobiusLibrary module calculates the Mobius function for a given number.
    /// </summary>
    /// <remarks>
    /// The Möbius function is used in various areas of number theory, including:
    /// Inversion Formulas: It is used in the Möbius inversion formula, which is a technique to invert summatory functions.
    /// Prime Number Theorems: It appears in the study of the distribution of prime numbers.
    /// Combinatorial Identities: It is used in combinatorial mathematics to count certain types of structures.
    /// </remarks>
    public class MobiusLibrary
    {
        /// <summary>
        /// This method calculates the Mobius function for a given number.
        /// </summary>
        /// <param name="number">A positive number, for which the Mobius function is being calculated.</param>
        /// <returns>The Mobius solution for the given number.</returns>
        public static int Mobius(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            var primeFactorCount = 0;

            for (var i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    number /= i;

                    primeFactorCount++;

                    if (number % i == 0)
                    {
                        return 0;
                    }
                }
            }
            return primeFactorCount % 2 == 0 ? 1 : -1;
        }
    }
}
