
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace learnAPIs.Models
{
    public class Dog
    {
        public Dog(string name, string color, int happiness, string breed)
        {
            Name = name;
            Color = color;
            Happiness = happiness;
            Breed = breed;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Happiness { get; set; }
        public string Id { get; set; }
        public string Breed { get; set; }
    }
}