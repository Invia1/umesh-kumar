using System;
using System.Collections.Generic;


namespace day7
{
    class Class3
    {
        List<string> obj = new List<string>();
        public void ADD()
        {
            //first list element
            obj.Add("Rahul");
            obj.Add("Abhishek");
            obj.Add("umesh");

            obj.Add("Rakesh");
            obj.Add("suresh");
            obj.Add("Rekha");
        }
        public void insertat(int i, string name)
        {
            obj.Insert(i,name);
        }

        public void update(int i, string updated)
        {
            obj.RemoveAt(i);
            obj.Insert(i, updated);
        }
        public void search(string a)
        {
            var temp=obj.Contains(a);
            if(temp==true)
            {
                Console.WriteLine("yes this name is exist:"+a);
            }
            else
            {
                Console.WriteLine("No this name does not exist:"+a);
            }
        }

        //delete the elements from list
        public void delete(int a)
        {
            obj.RemoveAt(a);
        }

        //Fetch all the element of list 
        public void fetchall()
        {
            foreach (string temp in obj)
            {
                Console.WriteLine(temp);
            }
        }
    }
    class ppt
    {
        public static void Main(string[] args)
        {
            Class3 obj = new Class3();

            obj.ADD();
            obj.delete(2);
            obj.update(2, "subash");
            obj.insertat(0, "karan");
            obj.search("lokesh");
            obj.fetchall();

            Console.ReadLine();
        }
    }
}

