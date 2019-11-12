using System;

namespace Facade
{
    public class Vector2D
    {
        private Vector3D _vector = null;

        public Vector2D(double x, double y)
        {
            _vector = new Vector3D(x, y, 0);
        }

        private Vector2D(Vector3D vec)
        {
            _vector = vec;
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a._vector + b._vector);
        }

        public static Vector2D operator *(Vector2D v, double k)
        {
            return new Vector2D(v._vector * k);
        }

        public override string ToString()
        {
            return _vector.ToString();
        }
    }
}