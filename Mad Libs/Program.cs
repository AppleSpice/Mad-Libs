using System;

namespace Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            MadLibs();
        }

        static void MadLibs()
        {
            /*
      This program MadLibs
      Author: Gaven Rudiak
      */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs is starting!");

            // Give the Mad Lib a title:
            string title = "The Strange Morning";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter three adjectives (one per line): ");
            string adj1 = Console.ReadLine();
            string adj2 = Console.ReadLine();
            string adj3 = Console.ReadLine();

            Console.WriteLine("Enter one verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter two nouns (one per line): ");
            string noun1 = Console.ReadLine();
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter one animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter one food: ");
            string food = Console.ReadLine();
            Console.WriteLine("Enter one fruit: ");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter one superhero: ");
            string superhero = Console.ReadLine();
            Console.WriteLine("Enter one country: ");
            string country = Console.ReadLine();
            Console.WriteLine("Enter one dessert: ");
            string dessert = Console.ReadLine();
            Console.WriteLine("Enter one year: ");
            string year = Console.ReadLine();



            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}'s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}
