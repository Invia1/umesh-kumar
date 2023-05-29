using System;


namespace day15
{
    class Program
    {
       public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    
    }
    class Pogram2
    {
        public static void Main()
        {
            Program obj = new Program();
            Func<int, int, int> funcmath = obj.Add;
            var temp=funcmath(5, 11);
            Console.WriteLine(temp);

            funcmath = obj.Multiply;
            Console.WriteLine(funcmath(4, 5));

            Console.ReadLine();
        }
    }
}
