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
    public class ArithmeticLibrary
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


        public static int Sigma(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number must be a positive integer.");
            }

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Totient(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number must be a positive integer.");
            }

            int result = number;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    while (number % i == 0)
                    {
                        number /= i;
                    }
                    result -= result / i;
                }
            }

            if (number > 1)
            {
                result -= result / number;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int PrimeCounting(int number)
        {
            if (number < 2)
            {
                return 0;
            }

            bool[] isPrime = new bool[number + 1];
            for (int i = 2; i <= number; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= number; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            int primeCount = 0;
            for (int i = 2; i <= number; i++)
            {
                if (isPrime[i])
                {
                    primeCount++;
                }
            }

            return primeCount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Partition(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be a non-negative integer.");
            }

            int[] partitions = new int[number + 1];
            partitions[0] = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= number; j++)
                {
                    partitions[j] += partitions[j - i];
                }
            }

            return partitions[number];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Omega(int number)
        {
            if (number < 2)
            {
                return 0;
            }

            int totalPrimeFactors = 0;

            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    totalPrimeFactors++;
                    number /= i;
                }
            }

            if (number > 1)
            {
                totalPrimeFactors++;
            }

            return totalPrimeFactors;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double ChebyshevTheta(int number)
        {
            if (number < 2)
            {
                return 0;
            }

            double sum = 0;
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    sum += Math.Log(i);
                }
            }

            return sum;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double ChebyshevPsi(int number)
        {
            if (number < 2)
            {
                return 0;
            }

            double sum = 0;
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    int power = i;
                    while (power <= number)
                    {
                        sum += Math.Log(i);
                        power *= i;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Liouville(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number must be a positive integer.");
            }

            int omega = Omega(number);
            return (omega % 2 == 0) ? 1 : -1;
        }
    }
}
