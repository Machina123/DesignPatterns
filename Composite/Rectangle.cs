using System;

namespace Composite
{
    public class Rectangle : Graphic
    {
        public void Draw()
        {
            Console.WriteLine("Rysuję prostokąt");
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