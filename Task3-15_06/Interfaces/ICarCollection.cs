using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_15_06
{
    public interface ICarCollection<T>
    {
        void Add(T a);
        T this[string name] { get; }
        int Count { get; }
        void Clear();
    }
}
