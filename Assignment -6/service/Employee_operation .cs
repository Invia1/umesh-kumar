using System;
using System.Collections.Generic;
using day8.Modal;

namespace day8.service
{
    public class Employee_operation
    {
        List<Employee> obj1 = new List<Employee>();
        public List<Employee> createEmp(Employee emp)
        {
            obj1.Add(emp);
            return obj1; //obj1 is from List<employee>
        }

        public List<Employee> manager()
        {
            return obj1;
        }

        public void update(int id)
        {
            foreach (var temp in obj1)
            {
                if (temp.pid == id)
                {
                    temp.name = "shiva";
                    temp.pid = 23;
                    temp.Age = 21;
                    
                }
                else
                {
                    Console.WriteLine("data is not exist");
                    break;
                }
            }
        }
        public void Search(int id)
        {
            foreach(var temp in obj1)
            {
                if(temp.pid==id)
                {
                    Console.WriteLine("your data is found");
                    Console.WriteLine(temp.pid + " " + temp.name + " " + temp.Age);
                    Console.WriteLine();
                }
            }
        }

        public void remove(int id)
        {   
            int a = 0;
            foreach (Employee temp in obj1) //temp is Employee type
            {

                if (temp.pid == id)
                {
                    obj1.Remove(temp);
                    a++;
                    Console.WriteLine("Removed success");
                    break;
                }
            }
            if (a==0)
            {
                Console.WriteLine("Data not found");
                Console.WriteLine();
            }
        }
    }
}
    

