using System;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Teammate alpha = new Teammate();

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter a name for a new teammate:");
            string proposedName = Console.ReadLine();
            alpha.AddName(proposedName);


            Console.WriteLine("Enter teammate Skill Level: ");
            string proposedSkillInput = Console.ReadLine();
            int proposedSkill = int.Parse(proposedSkillInput);
            alpha.AddSkillLevel(proposedSkill);

            Console.WriteLine("Enter teammate courage: ");
            string proposedCourageInput = Console.ReadLine();
            double proposedCourage = Convert.ToDouble(proposedCourageInput);
            alpha.AddCourage(proposedCourage);

            Console.WriteLine(alpha.Name);
            Console.WriteLine(alpha.SkillLevel);
            Console.WriteLine(alpha.Courage);



        }
    }
}
