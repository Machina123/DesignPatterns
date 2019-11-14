namespace Iterator
{
    public class SimpleIterator<T> : Iterator<T>
    {
        public SimpleIterator(Aggregate<T> aggregate) : base(aggregate)
        {
        }

        public override T CurrentItem()
        {
            return this._aggregate[this._pos];
        }
    }
}