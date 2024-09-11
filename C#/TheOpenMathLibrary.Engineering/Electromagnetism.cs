@@ -0,0 + 1,118 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// ElectroMagnetism class contains methods for calculating various properties of electromagnetism.
    /// </summary>
    public class ElectroMagnetism
    {
        /// <summary>
        /// electric field and potential gradient 
        /// </summary>
        /// <param name="electricField"></param>
        /// <param name="potential"></param>
        /// <returns></returns>
        public static double ElectricFieldPotentialGradient(double electricField, double potential)
        {
            double potentialGradient = 0;
            potentialGradient = electricField / potential;
            return potentialGradient;
        }

        /// <summary>
        /// electric flux density 
        /// </summary>
        /// <param name="electricField"></param>
        /// <param name="permittivity"></param>
        /// <returns></returns>
        public static double ElectricFluxDensity(double electricField, double permittivity)
        {
            double electricFluxDensity = 0;
            electricFluxDensity = electricField / permittivity;
            return electricFluxDensity;
        }

        /// <summary>
        /// Absolute permittiity 
        /// </summary>
        /// <param name="electricFluxDensity"></param>
        /// <param name="electricField"></param>
        /// <returns></returns>
        public static double AbsolutePermittivity(double electricFluxDensity, double electricField)
        {
            double absolutePermittivity = 0;
            absolutePermittivity = electricFluxDensity / electricField;
            return absolutePermittivity;
        }

        /// <summary>
        /// electric dipole moment 
        /// </summary>
        /// <param name="charge"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static double ElectricDipoleMoment(double charge, double distance)
        {
            double electricDipoleMoment = 0;
            electricDipoleMoment = charge * distance;
            return electricDipoleMoment;
        }

        /// <summary>
        /// electric polarization 
        /// </summary>
        /// <param name="electricDipoleMoment"></param>
        /// <param name="volume"></param>
        /// <returns></returns>
        public static double ElectricPolarization(double electricDipoleMoment, double volume)
        {
            double electricPolarization = 0;
            electricPolarization = electricDipoleMoment / volume;
            return electricPolarization;
        }

        /// <summary>
        /// electric displacement field 
        /// </summary>
        /// <param name="electricPolarization"></param>
        /// <param name="permittivity"></param>
        /// <returns></returns>
        public static double ElectricDisplacementField(double electricPolarization, double permittivity)
        {
            double electricDisplacementField = 0;
            electricDisplacementField = electricPolarization / permittivity;
            return electricDisplacementField;
        }

        /// <summary>
        /// Electric displacement flux 
        /// </summary>
        /// <param name="electricDisplacementField"></param>
        /// <param name="area"></param>
        /// <returns></returns>
        public static double ElectricDisplacementFlux(double electricDisplacementField, double area)
        {
            double electricDisplacementFlux = 0;
            electricDisplacementFlux = electricDisplacementField * area;
            return electricDisplacementFlux;
        }

        /// <summary>
        /// Absolute electric potential 
        /// </summary>
        /// <param name="electricField"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static double AbsoluteElectricPotential(double electricField, double distance)
        {
            double absoluteElectricPotential = 0;
            absoluteElectricPotential = electricField * distance;
            return absoluteElectricPotential;
        }
    }
}
