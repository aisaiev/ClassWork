using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_15_06
{
    public class MyLinkedList<T>
    {
        public int Count { get; private set; }

        private Item<T> headItem;

        public void Add(T data)
        {
            if (headItem == null)
            {
                headItem = new Item<T>()
                {
                    Data = data,
                    NextItem = null
                };
                this.Count++;
            }
            else
            {
                Item<T> item = new Item<T>
                {
                    Data = data
                };
                Item<T> currentItem = this.headItem;
                while (currentItem.NextItem != null)
                {
                    currentItem = currentItem.NextItem;
                }
                currentItem.NextItem = item;
                this.Count++;
            }
        }
    }
}
