using System;
using System.Collections.Generic;
using Test_1.Modal;
using Test_1.Services;
using test.Interface;



namespace Test_1.UI
{
    class ui
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RIM Hospital portal:");
            Console.WriteLine("Please press the 'Enter' to Register your self for further process:");
            Console.ReadLine();
            var obj = new RIM();
        pool:

        A:
            int x=0;
            try {
                Console.WriteLine("Enter you registration ID;");
                 x = int.Parse(Console.ReadLine());
                if (x.Equals(""))
                { 
                    Console.WriteLine("The registration id cannot be  blank");
                    goto A;
                }
            }
            catch
            {
                Console.WriteLine("Enter the valid ID in numeric form");
                goto A;
            }
           
            
                
            
            B:
            Console.WriteLine("Enter the First_name");
            string a = Console.ReadLine();
             foreach(var temp in a)
            {
                if(char.IsDigit(temp))
                {
                    Console.WriteLine("enter valid name"); 
                    goto B;
                    
                   
                }
            }
            if(a=="")
            {
                Console.WriteLine("Name cannot be blank");
                goto B;
            }
            Console.WriteLine("Enter the Last_name");
            string b = Console.ReadLine();


        C:
            int c = 0; 
            try {
                Console.WriteLine("Enter the Age:");
                 c = int.Parse(Console.ReadLine());
                if (c.Equals(""))
                {
                    Console.WriteLine("Age of the pat cannot be blank");
                    goto C;
                }
            }
            catch
            {
                Console.WriteLine("Enter valid AGE details in numeric form:");
                goto C;
            }


            Console.WriteLine("Enter the Address");
            D:
            string d = Console.ReadLine();
            if(d=="")
            {
                Console.WriteLine("Address cannot be blank");
                goto D;
            }


            E:
            Console.WriteLine("Enter the Aadhar no:");
            string e = (Console.ReadLine());
            try
            {
                long z = int.Parse(e);
                if (e == "")
                {
                    Console.WriteLine("Aadhar cannot be blank");
                    goto E;
                }
               
            }
            catch
            {
                Console.WriteLine("Enter the valid numeric number:");
                goto E;
            }


            K:
            Console.WriteLine("Enter your Gender M:male/F:female");
            char k = Convert.ToChar(Console.ReadLine());
            if(k=='M'||k=='F')
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Enter the valid gender in betwen M:male/F:female");
                goto K;
            }
           


            pof:
            Console.WriteLine("For which speciality:");
            Console.WriteLine("Select the speciality:");
            Console.WriteLine("1:Ortho" + "\n" + "2:Dental" + "\n" + "3:General Medicane:");
            string f = Console.ReadLine();

            //object of the moadal class

            Interface obj1 = new Logic();//line 
            List<RIM> list = obj1.getdata();//line 66
          

            obj.p_ID = x;
            obj.First_name = a;
            obj.last_name = b;
            obj.Age = c;
            obj.Aadhar_no = e;
            obj.Gender = k;
            obj.Address = d;
           
            string s = f;
            if (s == "2")
            {
                obj1.Denatal();
            }
            else if (s == "1")
            {
                obj1.ortho();
            }
            else if (s == "3")
            {
                obj1.General_medican();
            }
            else
            {
                Console.WriteLine("Enter the valid data for speaciality:");
                Console.WriteLine("Do yu want to continue Y/N");
                string o = Console.ReadLine();
                if (o == "y")
                {
                    goto pof;
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
            foreach (var temp in list)
            {
                Console.WriteLine(temp.p_ID + " " + temp.Aadhar_no + " " + temp.First_name + temp.last_name
                    + " " + temp.Age + " " + temp.Address + " " + temp.Gender + " " + temp.specality);
            }
            Console.WriteLine("Do you want to continue:yes/No");
            string p = Console.ReadLine();
            if (p == "yes")
            {
                goto pool;
            }
            else
            {
                Console.WriteLine("Have a nice day");
            }

            Console.ReadLine();
        }
    }
}
