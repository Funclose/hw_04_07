using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//TODO: 
namespace hw_04_07
{
    public class Point3D
    {
        public int X { get; set; }
        public int Y{ get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString() => $"x: {X}, y: {Y}, Z: {Z}";

        public double DistanceTo(Point3D other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2) + Math.Pow(other.Z - Z, 2));
        }
    }
    public static class ForPoint
    {
        public static int CalculateMax(Point3D[] point)
        {
            int MaxDistance = 0;

            for (int i = 0; i < point.Length; i++)
            {
                for (int j = i + 1; j < point.Length; j++)
                {
                    int distance = (int)point[i].DistanceTo(point[j]);
                    if (distance > MaxDistance)
                    {
                        MaxDistance = distance;
                    }
                }

            }
            return MaxDistance;
        }

        public static double AverageDistance(Point3D[] points)
        {
            double totalDistance = 0;
            int pairCount = 0;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    totalDistance += distance;
                    pairCount++;
                }
            }

            double averageDistance = totalDistance / pairCount;
            return averageDistance;
        }
        public static double AverageDistanceToOthers(Point3D[] points, Point3D point)
        {
            double totalDistance = 0;
            int count = 0;

            foreach (var other in points)
            {
                if (other != point)
                {
                    double distance = point.DistanceTo(other);
                    totalDistance += distance;
                    count++;
                }
            }

            return totalDistance / count;
        }
    }
}
