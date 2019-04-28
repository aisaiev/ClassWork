using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Handler
    {
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
