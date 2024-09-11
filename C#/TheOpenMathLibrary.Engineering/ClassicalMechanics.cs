namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// Classical Mechanics library - macroscopic object descriptions. The most familiar theories of physics.
    /// </summary>
    public class ClassicalMechanics
    {
        /// <summary>
        /// linear mass density
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static double LinearMassDensity(double mass, double length)
        {
            double linearMassDensity = 0;
            linearMassDensity = mass / length;
            return linearMassDensity;
        }

        /// <summary>
        /// surface mass density
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="area"></param>
        /// <returns></returns>
        public static double SurfaceMassDensity(double mass, double area)
        {
            double surfaceMassDensity = 0;
            surfaceMassDensity = mass / area;
            return surfaceMassDensity;
        }

        /// <summary>
        /// volumetric mass density
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="volume"></param>
        /// <returns></returns>
        public static double VolumetricMassDensity(double mass, double volume)
        {
            double volumetricMassDensity = 0;
            volumetricMassDensity = mass / volume;
            return volumetricMassDensity;
        }


        /// <summary>
        /// Moment of Mass
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double MomentOfMass(double mass, double radius)
        {
            double momentOfMass = 0;
            momentOfMass = mass * radius * radius;
            return momentOfMass;
        }

        /// <summary>
        /// Center of mass
        /// </summary>
        /// <param name="mass1"></param>
        /// <param name="mass2"></param>
        /// <param name="radius1"></param>
        /// <param name="radius2"></param>
        /// <returns></returns>
        public static double CenterOfMass(double mass1, double mass2, double radius1, double radius2)
        {
            double centerOfMass = 0;
            centerOfMass = (mass1 * radius1 + mass2 * radius2) / (mass1 + mass2);
            return centerOfMass;
        }

        /// <summary>
        /// 2 body reduced mass
        /// </summary>
        /// <param name="mass1"></param>
        /// <param name="mass2"></param>
        /// <returns></returns>
        public static double ReducedMass(double mass1, double mass2)
        {
            double reducedMass = 0;
            reducedMass = (mass1 * mass2) / (mass1 + mass2);
            return reducedMass;
        }

        /// <summary>
        /// moment of intertia 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double MomentOfInertia(double mass, double radius)
        {
            double momentOfInertia = 0;
            momentOfInertia = mass * radius * radius;
            return momentOfInertia;
        }
    }
}
