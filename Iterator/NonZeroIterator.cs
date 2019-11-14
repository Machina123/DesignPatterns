using System;

namespace Iterator
{
    public class NonZeroIterator<T> : Iterator<T>
    {
        public NonZeroIterator(Aggregate<T> aggregate) : base(aggregate)
        {
        }

        public override T CurrentItem()
        {
            try
            {
                if (!_aggregate[_pos].Equals(0)) return _aggregate[_pos];
                Next();
                return CurrentItem();
            }
            catch (IndexOutOfRangeException)
            {
                // koniec kolekcji, ostatni element to 0
                throw new InvalidOperationException();
            }
        }
    }
}