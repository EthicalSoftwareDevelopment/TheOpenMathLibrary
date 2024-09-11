using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOpenMathLibrary.GeneralMathematics
{
    public class GeometryFunctions
    {

        /// <summary>
        /// Triangle area function 
        /// </summary>
        /// <param name="baseLength"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double TriangleArea(double baseLength, double height)
        {
            double area = 0;
            area = 0.5 * baseLength * height;
            return area;
        }

        /// <summary>
        /// Cylinder Volume function 
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double CylinderVolume(double radius, double height)
        {
            double volume = 0;
            volume = 3.14159 * radius * radius * height;
            return volume;
        }

        /// <summary>
        /// Sphere Volume function 
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double SphereVolume(double radius)
        {
            double volume = 0;
            volume = 4 / 3 * 3.14159 * radius * radius * radius;
            return volume;
        }

        /// <summary>
        /// Rectangular prism volume function 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double RectangularPrismVolume(double length, double width, double height)
        {
            double volume = 0;
            volume = length * width * height;
            return volume;
        }
    }
}
