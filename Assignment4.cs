using System;


namespace day6
{
    class Food
    {
        public int Items { get; set; }
        public string student_name { get; set; }
        public int Lunch_box { get; set; }

    }
    class Food_manager
    {
        public Food function()
        {
            Food obj = new Food();
            int a;
            pool:
            try
            {   
                Console.WriteLine("Enter the No of items: ");
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please use only digit value:");
                goto pool;
            }
             obj.Items = a;
            

                loop:
                Console.WriteLine("Enter your name:");
                string b= Console.ReadLine();
                
                if (string.IsNullOrEmpty(b))
                {
                    Console.WriteLine("Name cannot be blank:");
                    goto loop;
                }
                foreach(var temp in b)
                {
                    if(char.IsDigit(temp))
                    {
                        Console.WriteLine("Name should not be a digit:");
                        goto loop;
                        
                    }
                }
                obj.student_name=b;
            prop:
            int c;
            try
            {
                Console.WriteLine("Enter the Number of Lunchbox:");
                c = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter the valid digit only:");
                goto prop;
            }

            obj.Lunch_box = c;

            return obj;
        }
    }
   
    
        class Student
        {
            public static void Main(string[] args)
            {
                var objHR = new Food_manager();
                Food temp = objHR.function();

                Console.WriteLine("Number of items of food:" + temp.Items);
                Console.WriteLine("Customer name is:" + temp.student_name);
                Console.WriteLine("Number of Lunches you want:" + temp.Lunch_box);

                Console.WriteLine("Your Order has Booked:");

                Console.ReadLine();

            }
        }
    }

