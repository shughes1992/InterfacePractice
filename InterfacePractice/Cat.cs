using System;
namespace InterfacePractice
{
    // Create the IFeedable interface
    // Follow the book to see what methods to put into the IFeedable interface
    // Have the Cat class implement the IFeedable interface
    // Implement the necessary methods defined in the interface
    public class Cat : IFeedable
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public int Snuggly { get; set; }

        public Cat(string name, string color, int snuggly)
        {
            Name = name;
            Color = color;
            Snuggly = snuggly;
        }

        public void Eat()
        {
            Console.WriteLine("scrounge crompch nya nya nya (Cat eating noises LOL");
        }
    }
}
