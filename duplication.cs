using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class lokesh
    {
      static void Main()
        {
            Console.WriteLine("Enter you input");
            string s = Console.ReadLine();
            int cnt = 1;
            int cou = 1;
            for(int i=0; i<s.Length; i++)
            {
                for(int j=i+1; j<s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        cnt++;
                        Console.WriteLine(s[j]);
                    }
                    else
                    {
                        Console.WriteLine(s[j]+" "+cou);
                    }
                }

            }

            Console.Write("The char comes in string:" + cnt);
            Console.ReadLine();
        }
    }
}
