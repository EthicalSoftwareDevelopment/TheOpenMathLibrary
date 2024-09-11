using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// This class contains functions for calculating various properties of light and electromagnetic radiation. It includes functions for calculating magnification, image height, image distance, poynting vector, poynting flux, RMS electric field, radiation momentum, radiant intensity, and radiosity. These functions can be used in physics and engineering applications to analyze and design optical systems.
    /// </summary>
    public class Optics
    {
        /// <summary>
        /// magnification function
        /// </summary>
        /// <param name="imageDistance"></param>
        /// <param name="objectDistance"></param>
        /// <returns></returns>
        public static double Magnification(double imageDistance, double objectDistance)
        {
            double magnification = 0;
            magnification = imageDistance / objectDistance;
            return magnification;
        }

        /// <summary>
        /// image height function
        /// </summary>
        /// <param name="magnification"></param>
        /// <param name="objectHeight"></param>
        /// <returns></returns>
        public static double ImageHeight(double magnification, double objectHeight)
        {
            double imageHeight = 0;
            imageHeight = magnification * objectHeight;
            return imageHeight;
        }

        /// <summary>
        /// image distance function 
        /// </summary>
        /// <param name="focalLength"></param>
        /// <param name="objectDistance"></param>
        /// <returns></returns>
        public static double ImageDistance(double focalLength, double objectDistance)
        {
            double imageDistance = 0;
            imageDistance = (focalLength * objectDistance) / (objectDistance - focalLength);
            return imageDistance;
        }

        /// <summary>
        /// Physical optics poynting vector function 
        /// </summary>
        /// <param name="electricField"></param>
        /// <param name="magneticField"></param>
        /// <returns></returns>
        public static double PoyntingVector(double electricField, double magneticField)
        {
            double poyntingVector = 0;
            poyntingVector = electricField * magneticField;
            return poyntingVector;
        }

        /// <summary>
        /// poyting flux, EM field power flow function 
        /// </summary>
        /// <param name="electricField"></param>
        /// <param name="magneticField"></param>
        /// <returns></returns>
        public static double PoyntingFlux(double electricField, double magneticField)
        {
            double poyntingFlux = 0;
            poyntingFlux = electricField * magneticField;
            return poyntingFlux;
        }

        /// <summary>
        /// RMS electric field of Light function 
        /// </summary>
        /// <param name="electricField"></param>
        /// <returns></returns>
        public static double RMSElectricField(double electricField)
        {
            double rmsElectricField = 0;
            rmsElectricField = electricField / Math.Sqrt(2);
            return rmsElectricField;
        }

        /// <summary>
        /// Radiation momentum function 
        /// </summary>
        /// <param name="intensity"></param>
        /// <param name="speedOfLight"></param>
        /// <returns></returns>
        public static double RadiationMomentum(double intensity, double speedOfLight)
        {
            double radiationMomentum = 0;
            radiationMomentum = intensity / speedOfLight;
            return radiationMomentum;
        }

        /// <summary>
        /// radiant intensity function 
        /// </summary>
        /// <param name="power"></param>
        /// <param name="solidAngle"></param>
        /// <returns></returns>
        public static double RadiantIntensity(double power, double solidAngle)
        {
            double radiantIntensity = 0;
            radiantIntensity = power / solidAngle;
            return radiantIntensity;
        }

        /// <summary>
        /// Radiosity function 
        /// </summary>
        /// <param name="emissivity"></param>
        /// <param name="stefanBoltzmannConstant"></param>
        /// <param name="temperature"></param>
        /// <returns></returns>
        public static double Radiosity(double emissivity, double stefanBoltzmannConstant, double temperature)
        {
            double radiosity = 0;
            radiosity = emissivity * stefanBoltzmannConstant * Math.Pow(temperature, 4);
            return radiosity;
        }

        /// <summary>
        /// Spectral radiance function 
        /// </summary>
        /// <param name="radiance"></param>
        /// <param name="wavelength"></param>
        /// <returns></returns>
        public static double SpectralRadiance(double radiance, double wavelength)
        {
            double spectralRadiance = 0;
            spectralRadiance = radiance / wavelength;
            return spectralRadiance;
        }

        /// <summary>
        /// spectral irradiance function 
        /// </summary>
        /// <param name="irradiance"></param>
        /// <param name="wavelength"></param>
        /// <returns></returns>
        public static double SpectralIrradiance(double irradiance, double wavelength)
        {
            double spectralIrradiance = 0;
            spectralIrradiance = irradiance / wavelength;
            return spectralIrradiance;
        }
    }
}
