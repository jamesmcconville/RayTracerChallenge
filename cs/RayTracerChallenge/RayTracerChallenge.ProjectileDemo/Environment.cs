using RayTracerChallenge.Lib;

namespace RayTracerChallenge.ProjectileDemo
{
    public class Environment
    {
        public Environment(Vector gravity, Vector wind)
        {
            Gravity = gravity;
            Wind = wind;
        }

        public Vector Gravity { get; set; }
        public Vector Wind { get; set; }
    }
}
