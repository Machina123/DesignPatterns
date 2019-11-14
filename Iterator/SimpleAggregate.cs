namespace Iterator
{
    public class SimpleAggregate<T> : Aggregate<T>
    {
        public SimpleAggregate(T[] data) : base(data)
        {
        }
        
        public override Iterator<T> GetIterator()
        {
            return new SimpleIterator<T>(this);
        }
    }
}