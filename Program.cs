using System;
// John Rowley
namespace SuperHeroesLesson1 
{
    class Program
    {
        static void Main(string[] args)
        {
            // PIck an hero from DC or Marvel universe and represent in code
            Console.WriteLine("I am The Batman from the DC Universe");

            string hero = "Spiderman";

            Console.WriteLine(hero);
            Console.WriteLine($"I am {hero} from the Marvel Universe");

            string Universe = "DC Universe";
            string heroName = "Superman";
            string Weakness = "kryptonite";
            string Power = "Super Strength, Super Speed";
          

            // String interpolation
            Console.WriteLine($"I am a {Universe} Super Hero my name is {heroName}!");
            Console.WriteLine($"My powers are {Power}");
            Console.WriteLine($"My Weakness is the {Weakness}");

            SuperHero MySuperHero = new SuperHero();

            MySuperHero.HeroName = "SuperMan";
            MySuperHero.Power = "Fast";
            MySuperHero.Weakness = "kryptonite";
            MySuperHero.Universe = "DC World";

            Console.WriteLine($"I am a {MySuperHero.Universe} Super Hero my name is {MySuperHero.HeroName}!");
            Console.WriteLine($"My powers are {MySuperHero.Power}");
            Console.WriteLine($"My Weakness is the {MySuperHero.Weakness}");

            SuperHero MySuperHero2 = new SuperHero();

            MySuperHero2.HeroName = "Spiderman";
            MySuperHero2.Power = "Web";
            MySuperHero2.Weakness = "Falling";
            MySuperHero2.Universe = "Marvel";

            Console.WriteLine($"I am a {MySuperHero2.Universe} Super Hero my name is {MySuperHero2.HeroName}!");
            Console.WriteLine($"My powers are {MySuperHero2.Power}");
            Console.WriteLine($"My Weakness is the {MySuperHero2.Weakness}");









        }
    }
}
