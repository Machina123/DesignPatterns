namespace Iterator
{
    public class NonZeroAggregate<T> : Aggregate<T>
    {
        public NonZeroAggregate(T[] data) : base(data)
        {
        }

        public override Iterator<T> GetIterator()
        {
            return new NonZeroIterator<T>(this);
        }
    }
    
}