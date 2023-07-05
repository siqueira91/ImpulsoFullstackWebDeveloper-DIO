using System;


namespace AbstraindoumJogodeRPGU.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {


            //public Wizard(string Name, int Level, string HeroType)

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia com bonus de " + Bonus;
            }else
            {
                return this.Name + " Lançou Magia fraca";
            }
        }

    }
}
