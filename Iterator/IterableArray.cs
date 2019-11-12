using System.Collections;

namespace Iterator
{
    public class IterableArray
    {
        private int[] data;

        public IterableArray(int[] data)
        {
            this.data = data;
        }
        
        public IEnumerable Elements
        {
            get { 
                for (int i = 0; i < data.Length; i++)
                {
                    yield return data[i];
                }
            }
        }

        public IEnumerable NonZeroElements
        {
            get
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != 0) yield return data[i];
                }
            }
        }
    }
}