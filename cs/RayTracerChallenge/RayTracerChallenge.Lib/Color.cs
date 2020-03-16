using System;

namespace RayTracerChallenge.Lib
{
    public class Color : Tuple<double, double, double, double>
    {
        public Color(double red, double green, double blue) : base(red, green, blue, 0.0)
        {
        }

        public double R => Item1;
        public double G => Item2;
        public double B => Item3;
        public double W => Item4;

        public static Color operator +(Color c1, Color c2) => new Color(c1.R + c2.R, c1.G + c2.G, c1.B + c2.B);
        public static Color operator -(Color c1, Color c2) => new Color(c1.R - c2.R, c1.G - c2.G, c1.B - c2.B);
        public static Color operator *(Color c1, Color c2) => new Color(c1.R * c2.R, c1.G * c2.G, c1.B * c2.B);
        public static Color operator *(Color c, double multiplier) => new Color(c.R * multiplier, c.G * multiplier, c.B * multiplier);
        public static Color operator *(double multiplier, Color c) => new Color(c.R * multiplier, c.G * multiplier, c.B * multiplier);

        public override bool Equals(object obj)
        {
            if (obj is Color color)
            {
                return R.IsApproximatelyEqualTo(color.R) 
                    && G.IsApproximatelyEqualTo(color.G) 
                    && B.IsApproximatelyEqualTo(color.B)
                    && W.IsApproximatelyEqualTo(color.W);
            }

            return false;
        }

        public override int GetHashCode() => R.GetHashCode() +
                2 * G.GetHashCode() +
                4 * B.GetHashCode() +
                8 * W.GetHashCode();
    }
}