using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class MyList
    {
        private int[] _array;

        public int Capacity { get; set; }

        public int Count { get; set; }

        public MyList()
        {
            _array = new int[2];
            Capacity = _array.Length;
            Count = 0;
        }

        public MyList(int length)
        {
            _array = new int[length];
            Capacity = length;
            Count = 0;
        }

        public MyList(int length, int element)
        {
            _array = new int[length];
            _array[0] = element;
            Capacity = length;
            Count = 1;
        }

        public void Add(int element)
        {
            if (Count >= Capacity)
                Resize();

            _array[Count] = element;
            Count++;
        }

        public void Add(int[] elements)
        {
            for(int i = 0; i < elements.Length; i++)
                Add(elements[i]);
        }

        public void Add(int index, int element)
        {
            if (Count >= Capacity)
                Resize();

            for (int i = Count; i >= index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = element;
            Count++;
        }

        //public void Add(int index, int[] elements)
        //{
        //    foreach(int element in elements)
        //    {
        //        Add(index, element);
        //        index++;
        //    }
        //}

        public void Add(int index, int[] elements)
        {
            Count = Count + elements.Length;
            if (Count >= Capacity)
                Resize(Count);

            for (int i = Count; i - elements.Length >= index; i--)
            {
                _array[i] = _array[i - elements.Length];
            }

            foreach (int element in elements)
            {
                _array[index] = element;
                index++;
            }
            Count++;
        }

        public int this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];

            }

            set
            {
                if(index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        private void Resize()
        {
            int newLength = _array.Length * 2;
            var newArray = new int[newLength];

            Copy(_array, newArray);
            _array = newArray;

            Capacity = _array.Length;
        }

        private void Resize(int count)
        {
            int newLength = count * 2;
            var newArray = new int[newLength];

            Copy(_array, newArray);
            _array = newArray;

            Capacity = _array.Length;
        }

        private void Copy(int[] sourceArray, int[] destinationArray)
        {
            if(sourceArray.Length > destinationArray.Length)
            {
                throw new ArgumentException();
            }

            for(int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }
        }
    }
}
