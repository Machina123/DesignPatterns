using System;

namespace Composite
{
    public class Line : Graphic
    {
        public void Draw()
        {
            Console.WriteLine("Rysuję linię");
        }

        public void Add(Graphic g)
        {
            throw new NotImplementedException();
        }

        public void Remove(Graphic g)
        {
            throw new NotImplementedException();
        }

        public Graphic GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }
}