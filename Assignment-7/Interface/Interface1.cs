using System;
using System.Collections.Generic;
using Assignment_7.Modal;
using Assignment_7.Service;

namespace Assignment_7.Interface
{
    interface Interface1
    {
         int createpl(Footbal foot);
        List<Footbal> getlist();
         void delete(int id);
        void update(int id);
        void search(int id);
    }
}
