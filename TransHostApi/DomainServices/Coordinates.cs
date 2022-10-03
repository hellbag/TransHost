using System;
using System.Threading.Tasks;
using TransHostApi.Model;


namespace TransHostApi.DomainServices
{
   
    public class Coordinates
    {
        /// <summary>
        /// Формула расчета расстояния между кооржинатами. Взято из интернетов.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        public static double GetDistance(Location src, Location dest)
        {
            double d = src.Lat * 0.017453292519943295;
            double num3 = src.Lon * 0.017453292519943295;
            double num4 = dest.Lat * 0.017453292519943295;
            double num5 = dest.Lon * 0.017453292519943295;
            double num6 = num5 - num3;
            double num7 = num4 - d;
            double num8 = Math.Pow(Math.Sin(num7 / 2.0), 2.0) + ((Math.Cos(d) * Math.Cos(num4)) * Math.Pow(Math.Sin(num6 / 2.0), 2.0));
            double num9 = 2.0 * Math.Atan2(Math.Sqrt(num8), Math.Sqrt(1.0 - num8));
            var result = (6376500.0 * num9) / 1000;
            return Math.Round(result, 3);
        }
    }
}