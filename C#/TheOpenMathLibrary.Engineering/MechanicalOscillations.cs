using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// Mechanical energy oscillation functions
    /// </summary>
    public class MechanicalOscillations
    {
        /// <summary>
        /// SHM Energy function 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="amplitude"></param>
        /// <param name="angularFrequency"></param>
        /// <returns></returns>
        public static double SHMEnergy(double mass, double amplitude, double angularFrequency)
        {
            double energy = 0;
            energy = 0.5 * mass * amplitude * amplitude * angularFrequency * angularFrequency;
            return energy;
        }

        /// <summary>
        /// DHM Energy function 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="amplitude"></param>
        /// <param name="angularFrequency"></param>
        /// <returns></returns>
        public static double DHMEnergy(double mass, double amplitude, double angularFrequency)
        {
            double energy = 0;
            energy = 0.5 * mass * amplitude * amplitude * angularFrequency * angularFrequency;
            return energy;
        }
    }
}
