
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11
{
    class Program
    {
     static void Main(string[] args)
        {
            List<string> objlist = new List<string>();
            objlist.Add("umesh");
            objlist.Add("lokesh");
            objlist.Add("pawan");
            objlist.Add("sansank");
            objlist.Add("pawan");
            objlist.Add("kailash");

            //Query to fetch the data
            var temp = from obj in objlist where obj=="pawan" select obj;
                     
            foreach(var t in temp)
            {
                Console.WriteLine(t + " ");
            }

            Console.ReadLine();
        }
    }
}
