namespace plan_your_heist
{
    class Teammate
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double Courage { get; set; }

        public void AddName(string name)
        {
            Name = name;
        }
        public void AddSkillLevel(int skill)
        {
            SkillLevel = skill;
        }

        public void AddCourage(double rating)
        {
            Courage = rating;
        }
    }
}