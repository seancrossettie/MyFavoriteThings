using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavoriteThings
{
    class Guitar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool Used { get; set; }
        public string Condition { get; set; }


        public Guitar(string brand, string model, bool used)
        {
            Brand = brand;
            Model = model;
            Used = used;

            if (used == true)
            {
                Condition = "used";
            } else
            {
                Condition = "new";
            }

            Console.WriteLine($"Check out this {Condition} {Brand} {Model}.");
        }
    }
}
