using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        class office
        {
             public const int ID=100;
           
             void print()
            {
                Console.WriteLine("The Id of the person is:" + office.ID);
            }
            public static void Main()
            {
             office obj = new office();
                obj.print();
                Console.ReadLine();
            }
        }
    }


