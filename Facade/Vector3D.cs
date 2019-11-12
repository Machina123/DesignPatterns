namespace Facade
{
    public class Vector3D
    {
        private double x, y, z;
        
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3D operator *(Vector3D v, double k)
        {
            return new Vector3D(v.x * k, v.y * k, v.z * k);
        }

        public override string ToString()
        {
            return $"Vector3D({x}, {y}, {z})";
        }
    }
}