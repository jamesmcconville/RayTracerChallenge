using System;

namespace RayTracerChallenge.Lib
{
    public class Point : Tuple<double, double, double, double>
    {
        public Point(double x, double y, double z) : base(x, y, z, 1.0)
        {
        }

        public double X => Item1;
        public double Y => Item2;
        public double Z => Item3;
        public double W => Item4;

        public static Vector operator -(Point p1, Point p2)
        {
            var x = p1.X - p2.X;
            var y = p1.Y - p2.Y;
            var z = p1.Z - p2.Z;
            return new Vector(x, y, z);
        }

        public static Point operator -(Point p, Vector v)
        {
            var x = p.X - v.X;
            var y = p.Y - v.Y;
            var z = p.Z - v.Z;
            return new Point(x, y, z);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point point)
            {
                var isEqual = X.IsApproximatelyEqualTo(point.X) && Y.IsApproximatelyEqualTo(point.Y) && Z.IsApproximatelyEqualTo(point.Z);
                return isEqual;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 2 + Y.GetHashCode() + 4 * Z.GetHashCode() + 8 * W.GetHashCode();
        }
    }
}
