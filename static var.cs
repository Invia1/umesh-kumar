using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   class kailash
    {
        static readonly int a=10;
        static  kailash()
        {
            kailash.a = 20;
        }
        static void Main()
        {
            int res  =kailash.a;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
