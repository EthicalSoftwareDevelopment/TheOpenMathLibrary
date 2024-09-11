namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// The study of fluids in motion
    /// </summary>
    public class FluidDynamics
    {
        /// <summary>
        /// flow velocity function
        /// </summary>
        /// <param name="flowRate"></param>
        /// <param name="pipeDiameter"></param>
        /// <returns></returns>
        public static double FlowVelocity(double flowRate, double pipeDiameter)
        {
            double velocity = 0;
            velocity = (4 * flowRate) / (3.14159 * pipeDiameter * pipeDiameter);
            return velocity;
        }

        /// <summary>
        /// velocity pseudovector function
        /// </summary>
        /// <param name="velocity"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double VelocityPseudovector(double velocity, double radius)
        {
            double pseudovector = 0;
            pseudovector = velocity * radius;
            return pseudovector;
        }

        /// <summary>
        /// volume flux function
        /// </summary>
        /// <param name="flowRate"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double VolumeFlux(double flowRate, double radius)
        {
            double volumeFlux = 0;
            volumeFlux = flowRate / (3.14159 * radius * radius);
            return volumeFlux;
        }

        /// <summary>
        /// mass current per volume function 
        /// </summary>
        /// <param name="massCurrent"></param>
        /// <param name="volume"></param>
        /// <returns></returns>
        public static double MassCurrentPerVolume(double massCurrent, double volume)
        {
            double massCurrentPerVolume = 0;
            massCurrentPerVolume = massCurrent / volume;
            return massCurrentPerVolume;
        }

        /// <summary>
        /// mass flow rate function 
        /// </summary>
        /// <param name="density"></param>
        /// <param name="volumeFlux"></param>
        /// <returns></returns>
        public static double MassFlowRate(double density, double volumeFlux)
        {
            double massFlowRate = 0;
            massFlowRate = density * volumeFlux;
            return massFlowRate;
        }

        /// <summary>
        /// mass current density function 
        /// </summary>
        /// <param name="density"></param>
        /// <param name="velocity"></param>
        /// <returns></returns>
        public static double MassCurrentDensity(double density, double velocity)
        {
            double massCurrentDensity = 0;
            massCurrentDensity = density * velocity;
            return massCurrentDensity;
        }

        /// <summary>
        /// momentum current desnity function 
        /// </summary>
        /// <param name="density"></param>
        /// <param name="velocity"></param>
        /// <returns></returns>
        public static double MomentumCurrentDensity(double density, double velocity)
        {
            double momentumCurrentDensity = 0;
            momentumCurrentDensity = density * velocity * velocity;
            return momentumCurrentDensity;
        }

        /// <summary>
        /// pressure gradient function 
        /// </summary>
        /// <param name="pressure"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static double PressureGradient(double pressure, double distance)
        {
            double pressureGradient = 0;
            pressureGradient = pressure / distance;
            return pressureGradient;
        }

        /// <summary>
        /// Buoyancy equations 
        /// </summary>
        /// <param name="density"></param>
        /// <param name="volume"></param>
        /// <param name="gravity"></param>
        /// <returns></returns>
        public static double BuoyancyForce(double density, double volume, double gravity)
        {
            double buoyancyForce = 0;
            buoyancyForce = density * volume * gravity;
            return buoyancyForce;
        }

        /// <summary>
        /// Bernoulli's equation 
        /// </summary>
        /// <param name="pressure"></param>
        /// <param name="density"></param>
        /// <param name="velocity"></param>
        /// <param name="height"></param>
        /// <param name="gravity"></param>
        /// <returns></returns>
        public static double BernoullisEquation(double pressure, double density, double velocity, double height, double gravity)
        {
            double bernoullisEquation = 0;
            bernoullisEquation = pressure + (density * velocity * velocity) + (density * gravity * height);
            return bernoullisEquation;
        }

        /// <summary>
        /// Eulers Equations 
        /// </summary>
        /// <param name="pressure"></param>
        /// <param name="density"></param>
        /// <param name="velocity"></param>
        /// <param name="height"></param>
        /// <param name="gravity"></param>
        /// <returns></returns>
        public static double EulersEquations(double pressure, double density, double velocity, double height, double gravity)
        {
            double eulersEquations = 0;
            eulersEquations = pressure + (density * velocity * velocity) + (density * gravity * height);
            return eulersEquations;
        }

        /// <summary>
        /// Convective acceleration function 
        /// </summary>
        /// <param name="velocity"></param>
        /// <param name="acceleration"></param>
        /// <returns></returns>
        public static double ConvectiveAcceleration(double velocity, double acceleration)
        {
            double convectiveAcceleration = 0;
            convectiveAcceleration = velocity * acceleration;
            return convectiveAcceleration;
        }

        /// <summary>
        /// Navier stokes equations 
        /// </summary>
        /// <param name="pressure"></param>
        /// <param name="density"></param>
        /// <param name="velocity"></param>
        /// <param name="height"></param>
        /// <param name="gravity"></param>
        /// <returns></returns>
        public static double NavierStokesEquations(double pressure, double density, double velocity, double height, double gravity)
        {
            double navierStokesEquations = 0;
            navierStokesEquations = pressure + (density * velocity * velocity) + (density * gravity * height);
            return navierStokesEquations;
        }
    }
}
