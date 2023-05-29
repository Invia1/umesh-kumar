using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    class Person
    {
        public void function()
        {
            Console.WriteLine("My self umesh:");
        }
    }
    class Class3
    {
        public static void Main()
        {
            Person obj = new Person();
            Action action = obj.function;
            action.Invoke();
           

            Console.ReadLine();
        }
    }
}
