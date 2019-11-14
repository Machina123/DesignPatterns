namespace Iterator
{
    public abstract class Aggregate<T>
    {
        private T[] data;

        public Aggregate(T[] data)
        {
            this.data = data;
        }

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }
        
        public int Length => data.Length;
        
        public abstract Iterator<T> GetIterator();
    }
}