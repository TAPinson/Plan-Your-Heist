using System;
using System.Collections.Generic;
using System.Linq;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Teammate> team = new List<Teammate>();
            int teammateToken = 0;
            while (teammateToken == 0)
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
            }

            Console.WriteLine($"Team Members: {team.Count}");

            int bankDifficulty = 100;

            List<int> teamSkillCatcher = new List<int>();

            foreach (Teammate member in team)
            {
                teamSkillCatcher.Add(member.SkillLevel);
            }

            int teamSkill = teamSkillCatcher.Sum();

            if (teamSkill > bankDifficulty)
            {
                Console.WriteLine("Successfully robbed bank");
            }
            else
            {
                Console.WriteLine("You have failed. You bring shame to your family...");
            }
        }
    }
}
