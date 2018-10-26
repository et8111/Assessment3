using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPeeps;

namespace WelcomToTheTeam
{
    class TeamMember : Person
    {
        public string Salary { get; set; }
        public string Address { get; set; }
        public TeamMember(string first, string last, string age, string email, string salary, string address) : base(first, last, age, email)
        {
            Salary = salary;
            Address = address;
        }
        public List<string> addList(string Fname, string Lname, string age, string email, string salary)
        {
            List<string> tempList = new List<string>();

            Console.WriteLine("Enter some sutff...");
            Console.Write("First Name: ");
            tempList.Add(Console.ReadLine());
            Console.Write("Last Name: ");
            tempList.Add(Console.ReadLine());
            Console.Write("Age: ");
            tempList.Add(Console.ReadLine());
            Console.Write("Email: ");
            tempList.Add(Console.ReadLine());
            Console.Write("Salary: ");
            tempList.Add(Console.ReadLine());
            return tempList;
        }
    }
}
