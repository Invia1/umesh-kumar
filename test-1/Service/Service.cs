﻿using System;
using System.Collections.Generic;
using Test_1.Modal;
using test.Interface;


namespace Test_1.Services
{
    class Logic:Interface
    {
        List<RIM> objlist = new List<RIM>();
        public int resgistration(RIM temp)
        {
            foreach (var tem in objlist)
            {
                if (tem.p_ID == temp.p_ID)
                {
                    Console.WriteLine("you id is duplicate" + tem.p_ID);
                }
            }
            objlist.Add(temp);
            return 1;
        }
        public List<RIM> getdata()
        {
            return objlist;
        }
        public void Denatal()
        {
            Console.WriteLine("Hello sir this is the Dental side of the RIM Hospital");
            Console.WriteLine("Enter your Name;");
            string n = Console.ReadLine();
            Console.WriteLine("hello" + " " + n + " " + "we will call you as soon as possible");
        }
        public void General_medican()
        {
            Console.WriteLine("Hello sir this is the General Medicans side of the RIM Hospital");
            Console.WriteLine("Which medicane you want:");
            string n = Console.ReadLine();
            Console.WriteLine("ok your request has listed:");
            Console.WriteLine(n);
        }
        public void ortho()
        {
            Console.WriteLine("Hello sir this is orthopadiecs  side of the RIM Hospital");
            Console.WriteLine("Tell us about your problem");
            string n = Console.ReadLine();
            Console.WriteLine("ok ortho specalist will meet you");
        }
        
    }
}
