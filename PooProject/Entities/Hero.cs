using System.Text;

namespace PooProject.Entities
{
    public abstract class Hero
    {
        protected string Name;
        protected int Level;
        protected string HeroType;
        protected int HealthPoints;
        protected int MaxHealthPoints;
        protected int MagicPoints;
        protected int MaxMagicPoints;


        public Hero(string Name, int Level, string HeroType, int HealthPoints, int MaxHealthPoints, int MagicPoints, int MaxMagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MaxHealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
            this.MaxMagicPoints = MaxMagicPoints;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**" + this.HeroType + "**");
            sb.AppendLine("Name: " + this.Name);
            sb.AppendLine("Level: " + this.Level);
            sb.AppendLine("HP: " + this.HealthPoints + "/" + this.MaxHealthPoints);
            sb.AppendLine("MP: "+ this.MagicPoints + "/" + this.MaxMagicPoints);

            return sb.ToString();
        }

        public virtual string Attack()
        {
            return this.Name + " type of attack\n";
        }
    }
}