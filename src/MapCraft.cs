using System;
using nStudio.Models;

namespace nStudio
{
    public class MapCraft
    {
        /// <summary>
        /// Converts kilometers to miles.
        /// </summary>
        /// <param name="kilometers"></param>
        /// <returns>Kilometers value as miles.</returns>
        public static double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371192;
        }


        /// <summary>
        /// Converts miles to kilometers.
        /// </summary>
        /// <param name="miles"></param>
        /// <returns>Miles value as kilometers.</returns>
        public static double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.60934;
        }


        public static double CalculateCoordinateDistance(CoordinateDistance data, Boolean returnMiles = true)
        {
            double long_1 = Convert.ToDouble(data.long_1);
            double lat_1 = Convert.ToDouble(data.lat_1);
            double long_2 = Convert.ToDouble(data.long_2);
            double lat_2 = Convert.ToDouble(data.lat_2);

            // convert coordinate into 'radian' format. 
            double mathRadian = 3.14159265358979323846 / 180;

            lat_1 = lat_1 * mathRadian;
            long_1 = long_1 * mathRadian;
            lat_2 = lat_2 * mathRadian;
            long_2 = long_2 * mathRadian;

            double earthRadius = 6378.137;
            double longDiff = long_2 - long_1;

            // formula for calculate distance between two coordinate and return result in 'KM'
            double distance = Math.Acos(Math.Sin(lat_1) * Math.Sin(lat_2) +
                                        Math.Cos(lat_1) * Math.Cos(lat_2) *
                                        Math.Cos(longDiff)) * earthRadius;

            double result;
            if (returnMiles == true)
            {
                result = ConvertKilometersToMiles(distance);
            }
            else
            {
                result = distance;
            }

            return result;
        }
    }
}
