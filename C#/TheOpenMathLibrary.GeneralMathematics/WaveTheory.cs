using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.GeneralMathematics
{
    /// <summary>
    /// Wave theory - the study of the properties of waves
    /// </summary>
    public class WaveTheory
    {
        /// <summary>
        /// Wavelength function 
        /// </summary>
        /// <param name="waveSpeed"></param>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public static double Wavelength(double waveSpeed, double frequency)
        {
            double wavelength = 0;
            wavelength = waveSpeed / frequency;
            return wavelength;
        }

        /// <summary>
        /// Wave vector function 
        /// </summary>
        /// <param name="waveSpeed"></param>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public static double WaveVector(double waveSpeed, double frequency)
        {
            double waveVector = 0;
            waveVector = 2 * 3.14159 * frequency / waveSpeed;
            return waveVector;
        }

        /// <summary>
        /// Frequency function 
        /// </summary>
        /// <param name="waveSpeed"></param>
        /// <param name="wavelength"></param>
        /// <returns></returns>
        public static double Frequency(double waveSpeed, double wavelength)
        {
            double frequency = 0;
            frequency = waveSpeed / wavelength;
            return frequency;
        }

        /// <summary>
        /// Angular frequency function 
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public static double AngularFrequency(double frequency)
        {
            double angularFrequency = 0;
            angularFrequency = 2 * 3.14159 * frequency;
            return angularFrequency;
        }

        /// <summary>
        /// Oscillatory velocity 
        /// </summary>
        /// <param name="amplitude"></param>
        /// <param name="angularFrequency"></param>
        /// <param name="time"></param>
        /// <param name="phase"></param>
        /// <returns></returns>
        public static double OscillatoryVelocity(double amplitude, double angularFrequency, double time, double phase)
        {
            double oscillatoryVelocity = 0;
            oscillatoryVelocity = amplitude * Math.Sin(angularFrequency * time + phase);
            return oscillatoryVelocity;
        }

        /// <summary>
        /// Oscillatory acceleration 
        /// </summary>
        /// <param name="amplitude"></param>
        /// <param name="angularFrequency"></param>
        /// <param name="time"></param>
        /// <param name="phase"></param>
        /// <returns></returns>
        public static double OscillatoryAcceleration(double amplitude, double angularFrequency, double time, double phase)
        {
            double oscillatoryAcceleration = 0;
            oscillatoryAcceleration = amplitude * angularFrequency * Math.Cos(angularFrequency * time + phase);
            return oscillatoryAcceleration;
        }

        /// <summary>
        /// Phase velocity 
        /// </summary>
        /// <param name="waveSpeed"></param>
        /// <param name="waveVector"></param>
        /// <returns></returns>
        public static double PhaseVelocity(double waveSpeed, double waveVector)
        {
            double phaseVelocity = 0;
            phaseVelocity = waveSpeed / waveVector;
            return phaseVelocity;
        }

        /// <summary>
        /// Group velocity 
        /// </summary>
        /// <param name="waveSpeed"></param>
        /// <param name="waveVector"></param>
        /// <returns></returns>
        public static double GroupVelocity(double waveSpeed, double waveVector)
        {
            double groupVelocity = 0;
            groupVelocity = waveSpeed / waveVector;
            return groupVelocity;
        }

        /// <summary>
        /// Time delay 
        /// </summary>
        /// <param name="time"></param>
        /// <param name="phase"></param>
        /// <returns></returns>
        public static double TimeDelay(double time, double phase)
        {
            double timeDelay = 0;
            timeDelay = time - phase;
            return timeDelay;
        }

        /// <summary>
        /// Phase difference 
        /// </summary>
        /// <param name="phase1"></param>
        /// <param name="phase2"></param>
        /// <returns></returns>
        public static double PhaseDifference(double phase1, double phase2)
        {
            double phaseDifference = 0;
            phaseDifference = phase1 - phase2;
            return phaseDifference;
        }

        /// <summary>
        /// Phase function
        /// </summary>
        /// <param name="waveVector"></param>
        /// <param name="position"></param>
        /// <param name="time"></param>
        /// <param name="phase"></param>
        /// <returns></returns>
        public static double Phase(double waveVector, double position, double time, double phase)
        {
            phase = waveVector * position - 2 * 3.14159 * time + phase;
            return phase;
        }
    }
}
