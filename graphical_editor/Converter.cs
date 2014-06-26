using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawingEngine.Common
{
    class Converter
    {
        /// <summary>
        /// Перевод радиан в градусы
        /// </summary>
        /// <param name="radians">Радиан</param>
        /// <returns>Градусы</returns>
        public static double toDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        /// <summary>
        /// Перевод градусов в радианы
        /// </summary>
        /// <param name="degrees">Градусы</param>
        /// <returns>Радианы</returns>
        public static double toRadians(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
    }
}
