using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps
{
    class Program
    {
        static void NEWPERSON(List<Person> person)
        {
            Console.WriteLine("Enter the following info...");
            Console.Write("Age: ");
            string tempAge = Console.ReadLine();

            if (int.Parse(tempAge) <= 18)
                Console.WriteLine("Whos CHAI OLD IS THIS?!?!?");
            else
            {
                string tempF = "", tempL = "", tempE = "";
                ask1:
                Console.Write("First Name: ");
                tempF = Console.ReadLine();
                if (tempF.Contains(" "))
                {
                    Console.WriteLine("ONE NAME ONLY");
                    goto ask1;
                }
                ask2:
                Console.Write("Last Name: ");
                tempL = Console.ReadLine();
                if (tempL.Contains(" "))
                {
                    Console.WriteLine("ONE NAME ONLY");
                    goto ask2;
                }
                Console.Write("Email: ");
                tempE = Console.ReadLine();
                person.Add(new Person(tempF, tempL, int.Parse(tempAge), tempE));
            }
        }

        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            person.Add(new Person("Robert", "Paulson", 35, "rp123@gmail.com"));
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    NEWPERSON(person);
                    foreach (var v in person)
                    {
                        Console.WriteLine($"{v.FirstName} {v.LastName}, age {v.Age}. Email {v.Email}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write("Enter 'n' to quit: ");
                if (Console.ReadLine().ToLower() == "n")
                    break;
            }
        }
    }
}
