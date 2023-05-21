using System;
using System.Collections.Generic;
using Test_1.Modal;
using Test_1.Services;


namespace Test_1.UI
{
    class ui
    {
      public static void Main(string[] args)
        {
            pool:
            Console.WriteLine("Enter you registration ID;");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the First_name");
            string a = Console.ReadLine();
            Console.WriteLine("Enther the Last_name");
            string b = Console.ReadLine();
            Console.WriteLine("Entert the Age:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Address");
            string d = Console.ReadLine();
            Console.WriteLine("Enter the Aadhar no:");
            string e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Gender");
            char k = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("For which speciality:");
            string f = Console.ReadLine();

            var obj = new RIM();
            Logic obj1 = new Logic();//line 
            List<RIM> list = obj1.getdata();//line 66
            
            obj.p_ID = x;
            obj.First_name = a;
            obj.last_name = b;
            obj.Age = c;
            obj.Aadhar_no = e;
            obj.Gender = k;
            obj.Address = d;
         
            string s = f;
            if (s=="Dental")
            {
                obj1.Denatal();
            }
            else if(s=="ortho")
            {
                obj1.ortho();
            }
            else if(s=="General med")
            {
                obj1.General_medican();
            }
            else
            {
                Console.WriteLine("Enter the valid data for speaciality:");
                Console.WriteLine("Do yu want to continue Y/N");
                string o = Console.ReadLine();
                if(o=="y")
                {
                    goto pool;
                }
                else
                {
                    Console.WriteLine("Be Healthy and safe:");
                }
            }

            obj.specality = s;
            obj1.resgistration(obj);

            Console.WriteLine();
            Console.WriteLine("And your details is:");
            Console.WriteLine("ID" + " " + "Aadhar no" + "Name" + " " + "Age" + " " + "Address" + " " + "Gender" + " " + "Speciality");
            foreach(var temp in list)
            {
                Console.WriteLine(temp.p_ID + " " + temp.Aadhar_no + " " + temp.First_name + temp.last_name
                    +" "+temp.Age+" "+temp.Address+" "+temp.Gender+" "+temp.specality);
            }
            Console.ReadLine();
        }
    }
}
