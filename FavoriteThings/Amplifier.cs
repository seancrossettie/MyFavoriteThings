using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavoriteThings
{
    class Amplifier
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Watts { get; set; }
        private string Loudness { get; set; }

        public Amplifier(string brand, string model, int watts)
        {
            Brand = brand;
            Model = model;
            Watts = watts;

            if (watts >= 20)
            {
                Loudness = "It'll make your ears bleed, man.";
            } else
            {
                Loudness = "It's pretty polite.";
            }

            Console.WriteLine($"I just stole this {Brand} {Model} that has {Watts} watts. {Loudness}");
        }
    }
}
