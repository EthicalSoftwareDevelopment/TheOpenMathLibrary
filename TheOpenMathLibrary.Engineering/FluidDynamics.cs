namespace TheOpenMathLibrary.Engineering
{
    public class FluidDynamics
    {
        //flow velocity function
        public static double FlowVelocity(double flowRate, double pipeDiameter)
        {
            double velocity = 0;
            velocity = (4 * flowRate) / (3.14159 * pipeDiameter * pipeDiameter);
            return velocity;
        }

        //velocity pseudovector function
        public static double VelocityPseudovector(double velocity, double radius)
        {
            double pseudovector = 0;
            pseudovector = velocity * radius;
            return pseudovector;
        }

        //volume flux function
        public static double VolumeFlux(double flowRate, double radius)
        {
            double volumeFlux = 0;
            volumeFlux = flowRate / (3.14159 * radius * radius);
            return volumeFlux;
        }

        //mass current per volume function
        public static double MassCurrentPerVolume(double massCurrent, double volume)
        {
            double massCurrentPerVolume = 0;
            massCurrentPerVolume = massCurrent / volume;
            return massCurrentPerVolume;
        }

        //mass flow rate function
        public static double MassFlowRate(double density, double volumeFlux)
        {
            double massFlowRate = 0;
            massFlowRate = density * volumeFlux;
            return massFlowRate;
        }

        //mass current density function
        public static double MassCurrentDensity(double density, double velocity)
        {
            double massCurrentDensity = 0;
            massCurrentDensity = density * velocity;
            return massCurrentDensity;
        }

        //momentum current desnity function
        public static double MomentumCurrentDensity(double density, double velocity)
        {
            double momentumCurrentDensity = 0;
            momentumCurrentDensity = density * velocity * velocity;
            return momentumCurrentDensity;
        }

        //pressure gradient function
        public static double PressureGradient(double pressure, double distance)
        {
            double pressureGradient = 0;
            pressureGradient = pressure / distance;
            return pressureGradient;
        }

        //Buoyancy equations
        public static double BuoyancyForce(double density, double volume, double gravity)
        {
            double buoyancyForce = 0;
            buoyancyForce = density * volume * gravity;
            return buoyancyForce;
        }

        //Bernoulli's equation
        public static double BernoullisEquation(double pressure, double density, double velocity, double height, double gravity)
        {
            double bernoullisEquation = 0;
            bernoullisEquation = pressure + (density * velocity * velocity) + (density * gravity * height);
            return bernoullisEquation;
        }

        //Eulers Equations
        public static double EulersEquations(double pressure, double density, double velocity, double height, double gravity)
        {
            double eulersEquations = 0;
            eulersEquations = pressure + (density * velocity * velocity) + (density * gravity * height);
            return eulersEquations;
        }

        //Convective acceleration function
        public static double ConvectiveAcceleration(double velocity, double acceleration)
        {
            double convectiveAcceleration = 0;
            convectiveAcceleration = velocity * acceleration;
            return convectiveAcceleration;
        }

        //Navier stokes equations
        public static double NavierStokesEquations(double pressure, double density, double velocity, double height, double gravity)
        {
            double navierStokesEquations = 0;
            navierStokesEquations = pressure + (density * velocity * velocity) + (density * gravity * height);
            return navierStokesEquations;
        }
    }
}
