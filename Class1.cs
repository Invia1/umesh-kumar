using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        class office
        {
            static readonly int ID;
            static office()
            {
                office.ID = 45;
            }
            static void print()
            {
                Console.WriteLine("The Id of the person is:" + office.ID);
            }
            public static void Main()
            {
                office.print();
                Console.ReadLine();
            }
        }
    }


