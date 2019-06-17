using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_15_06
{
    public class CarCollection<T> : ICarCollection<T> where T : ICar
    {
        private T[] array;

        public int Count { get; private set; }

        public CarCollection()
        {
            this.array = new T[1];
            this.Count = 0;
        }

        public T this[string name]
        {
            get
            {
                T item = default;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Name == name)
                    {
                        item = this.array[i];
                        break;
                    }
                }
                return item;
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
    }
}
