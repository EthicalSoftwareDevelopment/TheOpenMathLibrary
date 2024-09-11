using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// The AngularFrequencies class in the TheOpenMathLibrary.Engineering namespace provides methods to calculate various angular frequencies in physics. 
    /// It includes methods for linear undamped unforced oscillators, linear unforced damped harmonic oscillators, low amplitude angular simple harmonic oscillators, and low amplitude simple pendulums. 
    /// Each method takes specific parameters and returns the corresponding angular frequency.
    /// </summary>
    public class AngularFrequencies
    {
        /// <summary>
        /// linear undamped unforced oscillator function
        /// </summary>
        /// <param name="angularFrequency"></param>
        /// <returns></returns>
        public static double LinearUndampedUnforcedOscillator(double angularFrequency)
        {
            double linearUndampedUnforcedOscillator = 0;
            linearUndampedUnforcedOscillator = angularFrequency;
            return linearUndampedUnforcedOscillator;
        }

        /// <summary>
        /// linear unforced DHO function 
        /// </summary>
        /// <param name="angularFrequency"></param>
        /// <param name="dampingCoefficient"></param>
        /// <returns></returns>
        public static double LinearUnforcedDHO(double angularFrequency, double dampingCoefficient)
        {
            double linearUnforcedDHO = 0;
            linearUnforcedDHO = angularFrequency * Math.Sqrt(1 - (dampingCoefficient * dampingCoefficient));
            return linearUnforcedDHO;
        }

        /// <summary>
        /// Low amplitutude angular SHO 
        /// </summary>
        /// <param name="angularFrequency"></param>
        /// <param name="amplitude"></param>
        /// <returns></returns>
        public static double LowAmplitudeAngularSHO(double angularFrequency, double amplitude)
        {
            double lowAmplitudeAngularSHO = 0;
            lowAmplitudeAngularSHO = angularFrequency * amplitude;
            return lowAmplitudeAngularSHO;
        }

        /// <summary>
        /// Low amplitude simple pendulum 
        /// </summary>
        /// <param name="angularFrequency"></param>
        /// <param name="amplitude"></param>
        /// <returns></returns>
        public static double LowAmplitudeSimplePendulum(double angularFrequency, double amplitude)
        {
            double lowAmplitudeSimplePendulum = 0;
            lowAmplitudeSimplePendulum = angularFrequency * amplitude;
            return lowAmplitudeSimplePendulum;
        }
    }
}
