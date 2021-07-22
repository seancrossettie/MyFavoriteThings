using System;
using MyFavoriteThings.FavoriteThings;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jazzmaster = new Guitar("Fender", "Jazzmaster", true);
            var Lemur = new Animal("Lemur", "enourmous", "Masters in Psychology");
            var AC30 = new Amplifier("Vox", "AC30", 30);
        }
    }
}
