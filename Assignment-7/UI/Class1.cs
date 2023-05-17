using System;
using System.Collections.Generic;
using Assignment_7.Interface;
using Assignment_7.Modal;
using Assignment_7.Service;

namespace Assignment_7.UI
{
     class Players
     {
       public static void Main(string[] args)
        {
            Footbal obj= new Footbal();
            obj.p_ID = 1;
            obj.p_Name = "Cristino";
            obj.p_age = 34;

            Footbal obj0 = new Footbal();
            obj0.p_ID = 2;
            obj0.p_Name = "Messy";
            obj0.p_age = 35;

            Footbal obj2 = new Footbal();
            obj2.p_ID = 3;
            obj2.p_Name = "shivam";
            obj2.p_age = 43;

            Interface1 obj1 =new Manage_players();
            obj1.createpl(obj);
            obj1.createpl(obj0);
            obj1.createpl(obj2);
            

            obj1.update(3);
            obj1.search(1);

            List<Footbal> p = obj1.getlist();
            foreach(Footbal temp in p)
            {
                Console.WriteLine(temp.p_Name + " " + temp.p_ID + " " + temp.p_age);
            }

            Console.ReadLine();

        }
        
     }
}
