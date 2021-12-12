using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsoleApp1
{
    class User:IComparable
    {
        string firstName;
        string lastName;
        string email;
        int birthYear;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int BirthYear { get; set; }
        public string Print()
        {
        return $"first name:{this.FirstName}last name:{this.LastName}email:{this.Email}Birth year:{this.BirthYear}";
        }
        public int CompareTo(object obj)
        {
            User user = (User)obj;
            if (this.BirthYear < user.BirthYear) return -1;
            if (this.BirthYear > user.BirthYear) return 1;
            return 0;
        }
    }
}
