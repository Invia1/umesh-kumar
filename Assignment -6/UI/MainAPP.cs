using System;
using System.Collections.Generic;
using day8.Modal;
using day8.service;
namespace day8.UI
{
    class MainAPP
    {
        public static void Main()
        {
            Employee deepa = new Employee();
            deepa.pid = 101;
            deepa.Age = 23;
            deepa.name = "lokesh";

            Employee deep = new Employee();
            deep.pid = 102;
            deep.name = "umesh";
            deep.Age = 34;

            Employee dee = new Employee();
            dee.pid = 103;
            dee.name = "kailsh";
            dee.Age = 43;

            Employee_operation ob = new Employee_operation();
            ob.createEmp(deepa);
            ob.createEmp(deep);
            ob.createEmp(dee);

            ob.remove(105);
            ob.Search(103);

            List<Employee> objlist = ob.manager();

            //The objlist pass the value to temp
            Console.WriteLine("your data is:");
            foreach(var temp in objlist)
            {
                Console.WriteLine(temp.Age + " " + temp.name + " " + temp.pid);
            }

            Console.ReadLine();

        }
    }
}
