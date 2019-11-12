using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D v3d1 = new Vector3D(1,2,3);
            Vector3D v3d2 = new Vector3D(2,3,4);
            Console.WriteLine($"v3d1 = {v3d1}\nv3d2 = {v3d2}");
            Vector3D v3d3 = v3d1 + v3d2;
            Console.WriteLine($"v3d3 = v3d2 + v3d1 = {v3d3}");
            Vector3D v3d4 = v3d1 * 2.5;
            Console.WriteLine($"v3d4 = v3d1 * 2.5 = {v3d4}");
            Console.WriteLine("--------------------------------");
            Vector2D v2d1 = new Vector2D(1,2);
            Vector2D v2d2 = new Vector2D(3,4);
            Console.WriteLine($"v2d1 = {v2d1}\nv2d2 = {v2d2}");
            Vector2D v2d3 = v2d1 + v2d2;
            Console.WriteLine($"v2d3 = v2d1 + v2d2 = {v2d3}");
            Vector2D v2d4 = v2d2 * 3.2;
            Console.WriteLine($"v2d4 = v2d2 * 3.2 = {v2d4}");
        }
    }
}