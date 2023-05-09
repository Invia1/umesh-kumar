using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bank
{
    int amount;
    string name;
    public string pname
    {
        get
        {
            return name;
        }
        set
        {
            name = value; //key word to put the value in variable
        }
    }
    public  int pamount
    {
        get
        {
            return amount;
        }
        set
        {
            amount = value; //key word to put the value in variable
            var obj = new Bank_manag();
            if(amount<=10000)
            {
                Console.WriteLine("You have an unvalid balance for shopping:");
            }
            else
            {
                Console.WriteLine("you have valid balance for Shoping:");
            }
        }
    }
}

class Bank_manag
{
    public void function()
    {
        Bank obj = new Bank();

        Console.WriteLine("Enter your Amount:");
        int a= int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Name");
        string b = Console.ReadLine();

        obj.pamount=a;
        obj.pname = b;

        Console.WriteLine("Account holder is:" + obj.pname);
        Console.WriteLine("Your Amount is:" + obj.pamount);
    }
}

class customer
{
    public static void Main()
    {
        var obj= new Bank_manag();
        obj.function();
        Console.ReadLine();
    }
}
