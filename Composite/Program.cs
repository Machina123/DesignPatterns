using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphic g = new Picture();
            g.Add(new Line());
            g.Add(new Rectangle());
            Picture sub = new Picture();
            sub.Add(new Text());
            sub.Add(new Line());
            sub.Add(new Rectangle());
            g.Add(sub);
            g.Add(new Line());
            g.Draw();
        }
    }
}