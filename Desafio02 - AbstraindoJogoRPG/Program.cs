using System;

namespace AbstraindoumJogodeRPGU.src.entities
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 42, "knight");
            Wizard wizard = new Wizard("Jennica", 42, "White Wizard");


            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.ReadLine();
        }
    }
}
