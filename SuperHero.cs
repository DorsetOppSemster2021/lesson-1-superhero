using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesLesson1
{
    public class SuperHero
    {
        //string Universe = "DC Universe";
        //string heroName = "Superman";
        //string Weakness = "kryptonite";
        //string Power = "Super Strength, Super Speed";

        public string Universe { get; set; }
        public string HeroName { get; set; }
        public string Weakness { get; set; }
        public string Power { get; set; }

        public override string ToString()
        {
            string message = $"I am a {Universe} Super Hero my name is {HeroName}!. ";
            message += $"My powers are {Power}. ";
            message += $"My Weakness is the {Weakness}. ";



            return message;
        }

    }
}
