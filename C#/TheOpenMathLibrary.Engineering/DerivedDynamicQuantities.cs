using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// Derived Dynamic Quantities library - derived dynamic quantities of macroscopic objects.
    /// </summary>
    public class DerivedDynamicQuantities
    {
        //Momentum function
        public static double Momentum(double mass, double velocity)
        {
            double momentum = 0;
            momentum = mass * velocity;
            return momentum;
        }

        //Force function
        public static double Force(double mass, double acceleration)
        {
            double force = 0;
            force = mass * acceleration;
            return force;
        }

        //Impulse function
        public static double Impulse(double force, double time)
        {
            double impulse = 0;
            impulse = force * time;
            return impulse;
        }

        //Angular momentum function
        public static double AngularMomentum(double mass, double velocity, double radius)
        {
            double angularMomentum = 0;
            angularMomentum = mass * velocity * radius;
            return angularMomentum;
        }

        //Torque function
        public static double Torque(double force, double radius)
        {
            double torque = 0;
            torque = force * radius;
            return torque;
        }

        //Angular impulse function
        public static double AngularImpulse(double torque, double time)
        {
            double angularImpulse = 0;
            angularImpulse = torque * time;
            return angularImpulse;
        }
    }
}
