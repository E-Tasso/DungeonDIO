namespace PooProject.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HealthPoints, int MaxHealthPoints, int MagicPoints, int MaxMagicPoints) : base(Name, Level, HeroType, HealthPoints, MaxHealthPoints, MagicPoints, MaxMagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MaxHealthPoints = MaxHealthPoints;
            this.MagicPoints = MagicPoints;
            this.MaxMagicPoints = MaxMagicPoints;
        }

        public override string Attack()
        {
            return this.Name + " has a dark magic attack\n";
        }
    }
}