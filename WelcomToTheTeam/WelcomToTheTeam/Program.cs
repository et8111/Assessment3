using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomToTheTeam
{
    class Program
    {
        static void newTeamMember(List<TeamMember> teamster)
        {
            List<string> temp = teamster[0].addList("", "", "", "", "");

            Console.WriteLine("Save this info(y/n)?: ");
            string temp1 = Console.ReadLine();
            if (temp1 == "y")
                teamster.Add(new TeamMember(temp[0],temp[1], temp[2], temp[3], temp[4], ""));
        }

        static void Main(string[] args)
        {
            List<TeamMember> teamster = new List<TeamMember>();
            teamster.Add(new TeamMember("Joe", "Deertay", "42", "testi@gmai.com", "30000.00", "123 washington drive" ));
            while (true)
            {
                try
                {
                    newTeamMember(teamster);
                    Console.WriteLine();
                    foreach (var v in teamster)
                        Console.WriteLine($"{v.FirstName} {v.LastName} {v.Age} {v.Email} {v.Salary} {v. Address}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write("enter 'n' to quit: ");
                if (Console.ReadLine().ToLower() == "n")
                    break;
            }
        }
    }
}
