namespace Iterator
{
    public abstract class Iterator<T>
    {
        protected int _pos;
        protected Aggregate<T> _aggregate;

        public Iterator(Aggregate<T> aggregate)
        {
            this._aggregate = aggregate;
        }

        public void First()
        {
            _pos = 0;
        }

        public void Next()
        {
            _pos++;
        }

        public bool IsDone()
        {
            return _pos >= _aggregate.Length;
        }

        public abstract T CurrentItem();

    }
}