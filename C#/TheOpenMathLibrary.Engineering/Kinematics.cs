using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// Kinematics library - the branch of classical mechanics which describes the motion of points, bodies (objects), and systems of bodies (groups of objects) without considering the forces that cause them to move.
    /// </summary>
    public class Kinematics
    {
        /// <summary>
        /// velocity function 
        /// </summary>
        /// <param name="displacement"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double Velocity(double displacement, double time)
        {
            double velocity = 0;
            velocity = displacement / time;
            return velocity;
        }

        /// <summary>
        /// accelartion function 
        /// </summary>
        /// <param name="velocity"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double Acceleration(double velocity, double time)
        {
            double acceleration = 0;
            acceleration = velocity / time;
            return acceleration;
        }

        /// <summary>
        /// jerk function 
        /// </summary>
        /// <param name="acceleration"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double Jerk(double acceleration, double time)
        {
            double jerk = 0;
            jerk = acceleration / time;
            return jerk;
        }

        /// <summary>
        /// jounce function 
        /// </summary>
        /// <param name="jerk"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double Jounce(double jerk, double time)
        {
            double jounce = 0;
            jounce = jerk / time;
            return jounce;
        }

        /// <summary>
        /// angular acceleration function 
        /// </summary>
        /// <param name="angularVelocity"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double AngularAcceleration(double angularVelocity, double time)
        {
            double angularAcceleration = 0;
            angularAcceleration = angularVelocity / time;
            return angularAcceleration;
        }

        /// <summary>
        /// angular jerk function 
        /// </summary>
        /// <param name="angularAcceleration"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double AngularJerk(double angularAcceleration, double time)
        {
            double angularJerk = 0;
            angularJerk = angularAcceleration / time;
            return angularJerk;
        }
    }
}
