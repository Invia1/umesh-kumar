using Assignment_7.Modal;
using System;
using Assignment_7.Interface;
using System.Collections.Generic;


namespace Assignment_7.Service
{
     class Manage_players: Interface1
    {
        List<Footbal> objlist = new List<Footbal>();
        public int createpl(Footbal foot)
        {
            objlist.Add(foot);
            return 1;
        }
        public List<Footbal> getlist()
        {
            return objlist;
        }
        public void delete(int id)
        {
            int p = 0;
            foreach (var temp in objlist)
            {
                if(temp.p_ID==id)
                {
                    objlist.Remove(temp);
                    p = 1;
                }
            }
            if (p == 0)
            {
                Console.WriteLine("The id does not exist:");
            }
        }
        public void update(int id)
        {
            int p = 0;
            foreach(var temp in objlist)
            {
                if(temp.p_ID==id)
                {
                    temp.p_ID = 3;
                    temp.p_age = 23;
                    temp.p_Name = "lokesh pal";
                    p = 1;
                }
            }
            if (p==0)
            {
                    Console.WriteLine("The id does not exist:");
            }
            
        }
        public void search(int id)
        {
            int p = 0;
            foreach(var temp in objlist)
            {
                if (temp.p_ID == id)
                {
                    Console.WriteLine("The entry is:");
                    Console.WriteLine(temp.p_Name+" "+temp.p_ID+" "+temp.p_age);
                    p = 1;
                }
                
            }
            if (p == 0)
            {
                Console.WriteLine("The id does not exist:");
            }
        }
        
    }
}
