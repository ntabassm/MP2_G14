using System;

namespace Simulation
{
    class SimulationMain
    {
        public static void Main()
        {
            int dimension = 3;  //initial grid dimension
            double vacancyProbability = 0.593; //initial vacancy probability
            int numOfTrials = 100;  //initial num of trials for MC
            bool[,] grid = new bool[3, 3]  //initial default grid;
                                           //also helpful for initial testing considering a specific grid 
            {
                { false, false, false},
                { false, false, false},
                { true, true, false}
            };

            while (true)
            {
                Console.WriteLine("Select from this menu:");
                Console.WriteLine("Grid parameters: di(m)ension, (v)acancy probability, (n)um of trials, (g)et parameters");
                Console.WriteLine("Single grid: (c)reate a grid, (d)isplay, (p)ercolate");
                Console.WriteLine("Monte Carlo: start Mon(t)e Carlo simulation");
                Console.WriteLine("Quit: (q)uit");
                Console.Write("\nYour choice: ");
                string choice;
                string result = "";
                try
                {
                    choice = Console.ReadLine().Trim().ToLower();
                }
                catch (Exception)
                {
                    Console.WriteLine($"IO error");
                    continue;
                }
                if (choice.StartsWith("m"))
                // implement your code below here

                    // End your implementation here
            }
        }


        /// <summary>
        /// Gets an int from the command line within the range [min, max]. 
        /// If the provided num is not acceptable, str will contain an error message.
        /// </summary>
        /// <param name="num">Nummber received from the user and returned through the out argument.</param>
        /// <param name="min">Min acceptable range for num.</param>
        /// <param name="max">Max acceptable range for num.</param>
        /// <param name="str">Contains an error message if not successful.</param>
        /// <returns>true if successful, false otherwise.</returns>
        static bool GetInt(out int num, int min, int max, ref string str)
        {
            if (int.TryParse(Console.ReadLine().Trim(), out num))
            {
                if (num >= min && num <= max)
                {
                    return true;
                }
                str = "Number outside range";
            }
            else
            {
                str = "Not an acceptable number";
            }
            return false;
        }
        /// <summary>
        /// Gets a double from the command line within the range [min, max]. 
        /// If the provided num is not acceptable, str will contain an error message.
        /// </summary>
        /// <param name="num">Nummber received from the user and returned through the out argument.</param>
        /// <param name="min">Min acceptable range for num.</param>
        /// <param name="max">Max acceptable range for num.</param>
        /// <param name="str">Contains an error message if not successful.</param>
        /// <returns>true if successful, false otherwise.</returns>
        static bool GetDouble(out double num, double min, double max, ref string str)
        {
            if (double.TryParse(Console.ReadLine().Trim(), out num))
            {
                if (num >= min && num <= max)
                {
                    return true;
                }
                str = "Number outside range";
            }
            else
            {
                str = "Not an acceptable number";
            }
            return false;
        }
    }
}