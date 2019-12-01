using System;

namespace Composite
{
    public interface Graphic
    {
        void Draw();

        void Add(Graphic g);

        void Remove(Graphic g);

        Graphic GetChild(int index);
    }
}