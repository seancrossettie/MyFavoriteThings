using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavoriteThings
{
    class Animal
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string EducationLevel { get; set; } = "GED";

        public Animal(string name, string size, string educationLevel)
        {
            Name = name;
            Size = size;
            EducationLevel = educationLevel;
            {
                Console.WriteLine($"That's a wild looking {Size} {Name}. I heard it has a {EducationLevel}.");
            }
        }
    }
}
