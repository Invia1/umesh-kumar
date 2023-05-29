using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    class Predic
    {
        public bool Isright(int a)
        {
            if(a==10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            Predic obj = new Predic();
            Predicate<int> mypre = obj.Isright;
             Console.WriteLine(mypre.Invoke(10));

            Console.ReadLine();
        }
    }
    
}
