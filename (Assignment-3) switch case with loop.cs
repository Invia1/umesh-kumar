using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class switch_case_with_loop
    {

        static void fibonacci()
        {
            Console.WriteLine("Enter you input for fibbonaci:");
            int num = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < num; i++)
            {
                int temp = a + b;
                Console.WriteLine(temp);
                a = b;
                b = temp;
               
            }
        }

        static void Factorial()
        {
            Console.WriteLine("Enter your input for Factorial:");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 2; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
        static void prime()
        {
            Console.WriteLine("Enter your input for prime:");
            int num = int.Parse(Console.ReadLine());
            if (num > 1)
            {
                int a = 0;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        //Console.WriteLine("It is not prime");
                        a++;
                        //break;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine("It is prime");
                }
                else
                {
                    Console.WriteLine("It is not prime");
                }
            }
            else
            {
                Console.WriteLine("enter number greater than 1");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter you input:");
            Console.WriteLine("1:Fibonacci;");
            Console.WriteLine("2:Factorial;");
            Console.WriteLine("3:Prime;");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                switch (num)
                {
                    case 1:
                        fibonacci();
                       
                        break;
                    case 2:
                        Factorial();
                        
                        break;
                    case 3:
                        prime();
                        break;

                    default:
                        Console.WriteLine("You entered wrong value:");
                        break;

                }
                Console.WriteLine("Do you want to continue yes/no");
                string p = Console.ReadLine();
                if(p=="yes")
                {
                    Main();
                }
                else
                {
                    break;
                }
            }
        }
         
    }
 }


