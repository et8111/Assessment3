using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool isAdult { get; set; }

        public Person(string first, string last, int age, string email)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            Email = email;
        }

        public bool getIsAdult()
        {
            if (Age > 18)
                isAdult = true;
            else
            {
                isAdult = false;
            }
            return isAdult;
        }

    }
}
