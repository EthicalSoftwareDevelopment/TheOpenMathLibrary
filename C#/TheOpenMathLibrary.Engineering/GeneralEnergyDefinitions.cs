using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    public class GeneralEnergyDefinitions
    {
        /// <summary>
        /// Mechanical work function
        /// </summary>
        /// <param name="force"></param>
        /// <param name="displacement"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double MechanicalWork(double force, double displacement, double angle)
        {
            double work = 0;
            work = force * displacement * Math.Cos(angle);
            return work;
        }

        /// <summary>
        /// Work done on Mechancial System function
        /// </summary>
        /// <param name="force"></param>
        /// <param name="displacement"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double WorkDoneOnMechanicalSystem(double force, double displacement, double angle)
        {
            double workDoneOnMechanicalSystem = 0;
            workDoneOnMechanicalSystem = force * displacement * Math.Cos(angle);
            return workDoneOnMechanicalSystem;
        }

        /// <summary>
        /// potential energy function
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="height"></param>
        /// <param name="gravity"></param>
        /// <returns></returns>
        public static double PotentialEnergy(double mass, double height, double gravity)
        {
            double potentialEnergy = 0;
            potentialEnergy = mass * height * gravity;
            return potentialEnergy;
        }

        /// <summary>
        /// Mechanical energy function
        /// </summary>
        /// <param name="kineticEnergy"></param>
        /// <param name="potentialEnergy"></param>
        /// <returns></returns>
        public static double MechanicalEnergy(double kineticEnergy, double potentialEnergy)
        {
            double mechanicalEnergy = 0;
            mechanicalEnergy = kineticEnergy + potentialEnergy;
            return mechanicalEnergy;
        }

        //Mechaical power function
        public static double MechanicalPower(double force, double velocity)
        {
            double mechanicalPower = 0;
            mechanicalPower = force * velocity;
            return mechanicalPower;
        }
    }
}
