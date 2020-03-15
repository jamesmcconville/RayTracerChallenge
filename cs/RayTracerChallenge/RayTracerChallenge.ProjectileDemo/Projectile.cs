using RayTracerChallenge.Lib;

namespace RayTracerChallenge.ProjectileDemo
{
    public class Projectile
    {
        public Projectile(Point position, Vector velocity)
        {
            Position = position;
            Velocity = velocity;
        }

        public Point Position { get; set; }
        public Vector Velocity { get; set; }
    }
}
