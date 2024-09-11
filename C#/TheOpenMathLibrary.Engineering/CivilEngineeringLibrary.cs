using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.Engineering
{
    /// <summary>
    /// Civil Engineering Library description: This library contains functions for civil engineering calculations.
    /// </summary>
    /// <remarks>
    /// This library is for educational purposes and should not be used in professional engineering applications.
    /// You use this library at your own risk.
    /// </remarks>
    public class CivilEngineeringLibrary
    {
        /// <summary>
        /// Cement quantity function 
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static double CementQuantity(double volume, double ratio)
        {
            double cementQuantity = 0;
            cementQuantity = volume / (1 + ratio);
            return cementQuantity;
        }

        /// <summary>
        /// Sand quantity function 
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static double SandQuantity(double volume, double ratio)
        {
            double sandQuantity = 0;
            sandQuantity = volume * ratio / (1 + ratio);
            return sandQuantity;
        }

        /// <summary>
        /// aggregate quantity function 
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static double AggregateQuantity(double volume, double ratio)
        {
            double aggregateQuantity = 0;
            aggregateQuantity = volume * ratio / (1 + ratio);
            return aggregateQuantity;
        }

        /// <summary>
        /// Slope as a percentage function 
        /// </summary>
        /// <param name="rise"></param>
        /// <param name="run"></param>
        /// <returns></returns>
        public static double SlopeAsPercentage(double rise, double run)
        {
            double slopeAsPercentage = 0;
            slopeAsPercentage = (rise / run) * 100;
            return slopeAsPercentage;
        }

        /// <summary>
        /// Slope as a ration function 
        /// </summary>
        /// <param name="rise"></param>
        /// <param name="run"></param>
        /// <returns></returns>
        public static double SlopeAsRatio(double rise, double run)
        {
            double slopeAsRatio = 0;
            slopeAsRatio = rise / run;
            return slopeAsRatio;
        }

        /// <summary>
        /// earthwork volume of cut or fill function 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public static double EarthworkVolume(double area, double depth)
        {
            double earthworkVolume = 0;
            earthworkVolume = area * depth;
            return earthworkVolume;
        }

        /// <summary>
        /// Average cross-sectional Area function 
        /// </summary>
        /// <param name="area1"></param>
        /// <param name="area2"></param>
        /// <returns></returns>
        public static double AverageCrossSectionalArea(double area1, double area2)
        {
            double averageCrossSectionalArea = 0;
            averageCrossSectionalArea = (area1 + area2) / 2;
            return averageCrossSectionalArea;
        }

        /// <summary>
        /// Steel quantity function 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="spacing"></param>
        /// <returns></returns>
        public static double SteelQuantity(double area, double spacing)
        {
            double steelQuantity = 0;
            steelQuantity = area / spacing;
            return steelQuantity;
        }

        /// <summary>
        /// Weight of Steel per Unit Length function 
        /// </summary>
        /// <param name="diameter"></param>
        /// <returns></returns>
        public static double WeightOfSteelPerUnitLength(double diameter)
        {
            double weightOfSteelPerUnitLength = 0;
            weightOfSteelPerUnitLength = 0.006165 * diameter * diameter;
            return weightOfSteelPerUnitLength;
        }

        /// <summary>
        /// Unit Weight of steel constant 
        /// </summary>
        /// <returns></returns>
        public static double UnitWeightOfSteel()
        {
            double unitWeightOfSteel = 0;
            unitWeightOfSteel = 7850;
            return unitWeightOfSteel;
        }

        /// <summary>
        /// Unit Weight of Concrete constant 
        /// </summary>
        /// <returns></returns>
        public static double UnitWeightOfConcrete()
        {
            double unitWeightOfConcrete = 0;
            unitWeightOfConcrete = 2400;
            return unitWeightOfConcrete;
        }

        /// <summary>
        /// Unit Weight of Brick constant 
        /// </summary>
        /// <returns></returns>
        public static double UnitWeightOfBrick()
        {
            double unitWeightOfBrick = 0;
            unitWeightOfBrick = 1920;
            return unitWeightOfBrick;
        }

        /// <summary>
        /// Unit Weight of Water constant 
        /// </summary>
        /// <returns></returns>
        public static double UnitWeightOfWater()
        {
            double unitWeightOfWater = 0;
            unitWeightOfWater = 1000;
            return unitWeightOfWater;
        }

        /// <summary>
        /// Load bearing capacity function 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="unitWeight"></param>
        /// <returns></returns>
        public static double LoadBearingCapacity(double area, double unitWeight)
        {
            double loadBearingCapacity = 0;
            loadBearingCapacity = area * unitWeight;
            return loadBearingCapacity;
        }

        /// <summary>
        /// Slab load calculation 
        /// </summary>
        /// <param name="liveLoad"></param>
        /// <param name="deadLoad"></param>
        /// <returns></returns>
        public static double SlabLoad(double liveLoad, double deadLoad)
        {
            double slabLoad = 0;
            slabLoad = liveLoad + deadLoad;
            return slabLoad;
        }

        /// <summary>
        /// Cantilever Beam Deflection 
        /// </summary>
        /// <param name="load"></param>
        /// <param name="length"></param>
        /// <param name="modulus"></param>
        /// <param name="inertia"></param>
        /// <returns></returns>
        public static double CantileverBeamDeflection(double load, double length, double modulus, double inertia)
        {
            double cantileverBeamDeflection = 0;
            cantileverBeamDeflection = (load * length * length * length) / (3 * modulus * inertia);
            return cantileverBeamDeflection;
        }

        /// <summary>
        /// Moment of Intertia of Rectangular Section 
        /// </summary>
        /// <param name="baseAmount"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double MomentOfInertiaOfRectangularSection(double baseAmount, double height)
        {
            double momentOfInertiaOfRectangularSection = 0;
            momentOfInertiaOfRectangularSection = (baseAmount * height * height * height) / 12;
            return momentOfInertiaOfRectangularSection;
        }

        /// <summary>
        /// Moment of Intertia of Circular Section 
        /// </summary>
        /// <param name="diameter"></param>
        /// <returns></returns>
        public static double MomentOfInertiaOfCircularSection(double diameter)
        {
            double momentOfInertiaOfCircularSection = 0;
            momentOfInertiaOfCircularSection = 3.14159 * diameter * diameter * diameter * diameter / 64;
            return momentOfInertiaOfCircularSection;
        }

        /// <summary>
        /// Bending Moment function 
        /// </summary>
        /// <param name="force"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static double BendingMoment(double force, double distance)
        {
            double bendingMoment = 0;
            bendingMoment = force * distance;
            return bendingMoment;
        }

        /// <summary>
        /// Shear force function 
        /// </summary>
        /// <param name="force"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static double ShearForce(double force, double distance)
        {
            double shearForce = 0;
            shearForce = force / distance;
            return shearForce;
        }

        /// <summary>
        /// Bricks calculation function 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double BricksCalculation(double length, double width, double height)
        {
            double bricksCalculation = 0;
            bricksCalculation = length * width * height;
            return bricksCalculation;
        }

        /// <summary>
        /// Dry Material Quantity for Mortar function 
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static double DryMaterialQuantityForMortar(double volume, double ratio)
        {
            double dryMaterialQuantityForMortar = 0;
            dryMaterialQuantityForMortar = volume * ratio / (1 + ratio);
            return dryMaterialQuantityForMortar;
        }

        /// <summary>
        /// Wet mortar volume function 
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static double WetMortarVolume(double volume, double ratio)
        {
            double wetMortarVolume = 0;
            wetMortarVolume = volume / (1 + ratio);
            return wetMortarVolume;
        }

        /// <summary>
        /// Excavation calculation function 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public static double ExcavationCalculation(double length, double width, double depth)
        {
            double excavationCalculation = 0;
            excavationCalculation = length * width * depth;
            return excavationCalculation;
        }

        /// <summary>
        /// Retaining Wall stability function 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="density"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double RetainingWallStability(double height, double width, double density, double angle)
        {
            double retainingWallStability = 0;
            retainingWallStability = height * width * density * 0.5 * Math.Sin(angle);
            return retainingWallStability;
        }

        /// <summary>
        /// One-way slab thickness function 
        /// </summary>
        /// <param name="span"></param>
        /// <param name="load"></param>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static double OneWaySlabThickness(double span, double load, double factor)
        {
            double oneWaySlabThickness = 0;
            oneWaySlabThickness = (span * span * span * load) / (8 * factor);
            return oneWaySlabThickness;
        }

        /// <summary>
        /// Two-way slab thickness function
        /// </summary>
        /// <param name="span"></param>
        /// <param name="load"></param>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static double TwoWaySlabThickness(double span, double load, double factor)
        {
            double twoWaySlabThickness = 0;
            twoWaySlabThickness = (span * span * span * load) / (12 * factor);
            return twoWaySlabThickness;
        }

        /// <summary>
        /// Compaction Factor function
        /// </summary>
        /// <param name="initialVolume"></param>
        /// <param name="finalVolume"></param>
        /// <returns></returns>
        public static double CompactionFactor(double initialVolume, double finalVolume)
        {
            double compactionFactor = 0;
            compactionFactor = initialVolume / finalVolume;
            return compactionFactor;
        }

        /// <summary>
        /// Soil Settlement function 
        /// </summary>
        /// <param name="initialVolume"></param>
        /// <param name="finalVolume"></param>
        /// <returns></returns>
        public static double SoilSettlement(double initialVolume, double finalVolume)
        {
            double soilSettlement = 0;
            soilSettlement = initialVolume - finalVolume;
            return soilSettlement;
        }
    }
}
