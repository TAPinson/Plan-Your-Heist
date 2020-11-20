using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Teammate> team = new List<Teammate>();
            int teammateToken = 0;
            while (teammateToken < 5)
            {
                Teammate alpha = new Teammate();

                Console.WriteLine("Plan Your Heist!");
                Console.WriteLine("Enter a name for a new teammate:");
                string proposedName = Console.ReadLine();
                if (proposedName == "")
                {
                    break;
                }
                else
                {
                    alpha.AddName(proposedName);
                }

                Console.WriteLine("Enter teammate Skill Level: ");
                string proposedSkillInput = Console.ReadLine();
                int proposedSkill = int.Parse(proposedSkillInput);
                alpha.AddSkillLevel(proposedSkill);

                Console.WriteLine("Enter teammate courage: ");
                string proposedCourageInput = Console.ReadLine();
                double proposedCourage = Convert.ToDouble(proposedCourageInput);
                alpha.AddCourage(proposedCourage);

                team.Add(alpha);
                teammateToken++;

            }

            Console.WriteLine(team.Count);

            foreach (Teammate member in team)
            {
                Console.WriteLine($"Teammate {member.Name} - Skill: {member.SkillLevel} - Courage: {member.Courage}");
            }

        }
    }
}
