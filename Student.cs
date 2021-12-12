using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsoleApp1
{
    class Student:User
    {
        string room;
        public string Room { get; set; }
        public string PrintDetails()
        {
            return $"{base.Print()}room:{this.Room}";
        }
    }
}
