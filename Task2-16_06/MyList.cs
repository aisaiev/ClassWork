using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_16_06
{
    class MyList<T> : IMyList<T>
    {
        T[] array;

        public int Count { get; private set; }

        public MyList()
        {
            this.array = new T[1];
            this.Count = 0;
        }

        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
        }

        public void Add(T item)
        {
            if (this.Count == 0)
            {
                this.array[0] = item;
                this.Count++;
            }
            else
            {
                T[] tempArray = new T[this.Count + 1];
                array.CopyTo(tempArray, 0);
                tempArray[array.Length] = item;
                array = tempArray;
                this.Count++;
            }
        }

        public void Clear()
        {
            this.array = new T[1];
            this.Count = 0;
        }

        public bool Contains(T item)
        {
            bool contains = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    contains = true;
                }
            }
            return contains;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"MyList Count: {this.Count}")
                .AppendLine().Append("MyList elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append(array[i]).Append(" ");
            }
            return stringBuilder.ToString();
        }
    }
}
