using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person_details
    {
        string name;
        public void change(string p)
        {
            name = p;
            dynamic pname = "rajeev"; //var isequal to string
            pname = 12.5;
            Console.WriteLine(pname);

        }
        static void Main()
        {
            var obj = new Person_details(); //var keyword is used to aliasin the class name
            obj.name="deepak";
            Console.WriteLine(obj.name);

            //var name = "rajeev";
            //
            obj.change("deepak srivastav"); 

            Console.WriteLine("changed name "+ obj.name);
            Console.ReadLine();
        }
    }
}
