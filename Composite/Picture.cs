using System;
using System.Collections.Generic;

namespace Composite
{
    public class Picture : Graphic
    {
        private List<Graphic> _graphics;

        public Picture() : base()
        {
            _graphics = new List<Graphic>();
        }
        
        public void Draw()
        {
            foreach (var g in _graphics)
            {
                g.Draw();
            }
        }

        public void Add(Graphic g)
        {
            _graphics.Add(g);
        }

        public void Remove(Graphic g)
        {
            _graphics.Remove(g);
        }

        public Graphic GetChild(int index)
        {
            return _graphics[index];
        }
    }
}