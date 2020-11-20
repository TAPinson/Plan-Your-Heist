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

            int infinityZero = 0;

            while (infinityZero == 0)
            {
                Console.WriteLine("How many trial runs should we go through?");
                string timesToTryResponse = Console.ReadLine();
                int timesToTry = Int16.Parse(timesToTryResponse);
                int counter = 0;
                while (counter < timesToTry)
                {
                    counter++;
                    int bankDifficulty = 100;

                    List<int> teamSkillCatcher = new List<int>();
                    foreach (Teammate member in team)
                    {
                        teamSkillCatcher.Add(member.SkillLevel);
                    }
                    int teamSkill = teamSkillCatcher.Sum();

                    Random r = new Random();
                    int luckValue = r.Next(1, 11);
                    bankDifficulty = bankDifficulty + luckValue;
                    Console.WriteLine($"Team Combined Skill: {teamSkill} --- Bank Difficulty: {bankDifficulty}");

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
    }
}
