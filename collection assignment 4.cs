using System;
using System.Collections;


namespace ConsoleApp1
{
    class data_entry
    {
        ArrayList array = new ArrayList();

        public void add_data()
        {   
            array.Add("umesh kumar");
            array.Add("lokesh parcha");
            array.Add("pawan parkash");
            array.Add("simran");
            array.Add("Rakesh malik");
            array.Insert(3,"prakash"); //used to insert element at specific point
           
            
        }
        public void remove_data()
        {   
            Console.WriteLine();
            Console.WriteLine("The updated array list:");
            array.Remove("umesh kumar");//remove the element by the data name
            array.RemoveAt(0);//They remove the element by thier index value
            //array.Clear();  //it used clear all the arraylist
            
            
        }
        public void print()
        {
            foreach (var temp in array)
            {
                Console.WriteLine(temp);
            }
        }

    //Main method of the class 
        public static void Main()
        {
            var obj = new data_entry();
            obj.add_data();
            obj.print();

            obj.remove_data();
            obj.print();
            

            Console.ReadLine();
        }
    }
}
