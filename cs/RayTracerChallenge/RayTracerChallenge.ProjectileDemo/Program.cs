using RayTracerChallenge.Lib;
using System;

namespace RayTracerChallenge.ProjectileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Projectile(new Point(0, 1, 0), new Vector(1, 1, 0).Normalize());
            var e = new Environment(new Vector(0, -0.1, 0), new Vector(-0.01, 0, 0));

            while (true)
            {
                Console.WriteLine($"{p.Position.X} {p.Position.Y}");

                p = Tick(e, p);
                if (p.Position.Y <= 0.0)
                    break;                    
            }

            Console.ReadKey();
        }

        private static Projectile Tick(Environment environment, Projectile projectile)
        {
            var position = projectile.Velocity + projectile.Position;
            var velocity = projectile.Velocity + environment.Gravity + environment.Wind;
            return new Projectile(position, velocity);
        }
    }
}
