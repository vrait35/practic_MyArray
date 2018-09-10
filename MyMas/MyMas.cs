using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMas
{
    public class MyArray<T>
    {
        private T[] array;

        public MyArray() {
            array = new T[0];
            Count = 0;
            Capacity = 0;
        }

        public MyArray(int capacity):this()
        {
            Capacity = capacity;
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public int Count { get; set; }   

        public void Add(T value)
        {
            if (Count < Capacity)
            {
                if(Count>0)
                array[Count - 1] = value;
            }
            else
            {
                Resize(Capacity + 1);
                array[Count] = value;
            }
            Count++;
        }

        public void Resize(int newSize)
        {
            if (Count > 0)
            {
                T[] buf = new T[Count];
                for (int i = 0; i < Count; i++)
                    buf[i] = array[i];

                array = new T[newSize];

                int min = Math.Min(newSize, Count);

                for (int i = 0; i < min; i++)
                    array[i] = buf[i];

            }
            else if (Count == 0)
            {
                array = new T[newSize];
            }
            Capacity = newSize;
        }

        public void Remove(T value)
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(value))
                    if (value.Equals(array[i]))
                    {
                        sum++;
                    }
            }
          T[] buf = new T[Count - sum];
            for (int i = 0, j = 0; i < Count; i++)
            {
                if (!array[i].Equals(value))
                {
                    buf[j] = array[i];
                    j++;
                }
            }
            array = new T[Count - sum];
            for (int i = 0; i < Count - sum; i++)
                array[i] = buf[i];
            Count -= sum;
        }

        public void Clear()
        {
            array = new T[Capacity];
            Count = 0;
        }

        public T IndexOf(int index)
        {
            return array[index];
        }
  
        public int Capacity{get;set;}       
    }
}
