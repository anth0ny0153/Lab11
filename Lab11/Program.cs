using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            int userInput;
            List<Movie> Netflix = new List<Movie>(); // create an instance 
            #region movies
            Netflix.Add(new Movie("Sci Fi", "Avengers:Infinity Wars"));
            Netflix.Add(new Movie("Sci Fi", "Star Wars"));
            Netflix.Add(new Movie("Horror", "IT"));
            Netflix.Add(new Movie("Horror", "The Conjuring"));
            Netflix.Add(new Movie("Horror", "Get Out"));
            Netflix.Add(new Movie("Drama", "Titanic"));
            Netflix.Add(new Movie("Drama", "Forrest Gump"));
            Netflix.Add(new Movie("Animated", "Toy Story"));
            Netflix.Add(new Movie("Animated", "Shrek"));
            Netflix.Add(new Movie("Animated", "The Incredibles"));
            #endregion
            while (repeat)
            {
                Console.WriteLine("There are 10 movies in the list");
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("1. Sci Fi, 2. Horror, 3. Drama, or 4. Animated?");
                string response = Console.ReadLine();
                while (!Regex.IsMatch(response, @"^[1-4]$"))
                {
                    Console.WriteLine("\nInvalid input. Please enter a number between 1-4: ");
                    response = Console.ReadLine();
                }
                userInput = int.Parse(response);
                // sci fi
                if (userInput == 1)
                {
                    Console.WriteLine($"You chose {Netflix[0].Categories}. Here are your list of movies.");
                    Console.WriteLine("_______________________________________________");

                    foreach (Movie m in Netflix)
                    {
                        if (m.Categories == "Sci Fi")
                            m.PrintInfo();
                    }
                }
                // horror
                else if (userInput == 2)
                {
                    Console.WriteLine($"You chose {Netflix[2].Categories}. Here are your list of movies.");
                    Console.WriteLine("_______________________________________________");
                    foreach (Movie m in Netflix)
                    {
                        if (m.Categories == "Horror")
                            m.PrintInfo();
                    }
                }
                // drama
                else if (userInput == 3)
                {
                    Console.WriteLine($"You chose {Netflix[5].Categories}. Here are your list of movies.");
                    Console.WriteLine("_______________________________________________");
                    foreach (Movie m in Netflix)
                    {
                        if (m.Categories == "Drama")
                            m.PrintInfo();
                    }
                }
                // animated
                else if (userInput == 4)
                {
                    Console.WriteLine($"You chose {Netflix[7].Categories}. Here are your list of movies.");
                    Console.WriteLine("_______________________________________________");
                    foreach (Movie m in Netflix)
                    {
                        if (m.Categories == "Animated")
                            m.PrintInfo();
                    }
                }
                repeat = Confirm("Do you want to continue?(y/n)");
            }
        }
        public static bool Confirm(string message) //method for yes or no questions
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input.ToLower() == "y") //continues program
            {
                return true;
            }
            else if (input.ToLower() == "n") //closes program
            {
                return false;
            }
            else //invalid input
            {
                Console.WriteLine("Invalid input.");
                return Confirm(message);
            }
        }
    }
}
