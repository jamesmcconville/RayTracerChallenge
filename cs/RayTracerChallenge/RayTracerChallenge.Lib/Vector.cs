using System;

namespace RayTracerChallenge.Lib
{
    public class Vector : Tuple<double, double, double, double>
    {
        public Vector(double x, double y, double z) : base(x, y, z, 0.0)
        {
        }

        public double X => Item1;
        public double Y => Item2;
        public double Z => Item3;
        public double W => Item4;
        public double Magnitude() => Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
        public Vector Normalize() => new Vector(X / Magnitude(), Y / Magnitude(), Z / Magnitude());
        public double Dot(Vector v) => X * v.X + Y * v.Y + Z * v.Z + W * v.W;


        public static Vector operator +(Vector v1, Vector v2)
        {
            var x = v1.X + v2.X;
            var y = v1.Y + v2.Y;
            var z = v1.Z + v2.Z;
            return new Vector(x, y, z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            var x = v1.X - v2.X;
            var y = v1.Y - v2.Y;
            var z = v1.Z - v2.Z;
            return new Vector(x, y, z);
        }

        public static Vector operator -(Vector v)
        {
            return Zero() - v;
        }

        public static Point operator +(Vector v, Point p)
        {
            var x = v.X + p.X;
            var y = v.Y + p.Y;
            var z = v.Z + p.Z;
            return new Point(x, y, z);
        }

        public static Vector operator *(Vector v, double magnitude)
        {
            var x = v.X * magnitude;
            var y = v.Y * magnitude;
            var z = v.Z * magnitude;
            return new Vector(x, y, z);
        }

        public static Vector operator /(Vector v, double magnitude)
        {
            var x = v.X / magnitude;
            var y = v.Y / magnitude;
            var z = v.Z / magnitude;
            return new Vector(x, y, z);
        }

        public static Vector Zero()
        {
            return new Vector(0, 0, 0);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector vector)
            {
                var isEqual = X.IsApproximatelyEqualTo(vector.X) && Y.IsApproximatelyEqualTo(vector.Y) && Z.IsApproximatelyEqualTo(vector.Z);
                return isEqual;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + 
                2 * Y.GetHashCode() + 
                4 * Z.GetHashCode() + 
                8 * W.GetHashCode();
        }
    }
}