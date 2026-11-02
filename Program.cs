using System;

namespace AnimalInformationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Header ---
            Console.WriteLine("--Animal Information Entry--");

            // 1. Input: Animal Name (string)
            Console.Write("Enter animal name: ");
            string animalName = Console.ReadLine();

            // 2. Input: Animal Count (int)
            Console.Write($"Enter number of {animalName}'s: ");
            int animalCount = Convert.ToInt32(Console.ReadLine());

            // 3. Input: Food Per Animal (double)
            Console.Write($"Enter pounds of food per {animalName} per day: ");
            double foodPerAnimal = Convert.ToDouble(Console.ReadLine());

            // 4 & 5. Calculations
            double totalDailyFood = animalCount * foodPerAnimal;
            double totalWeeklyFood = totalDailyFood * 7;

            // 6. Formatted Output Summary
            Console.WriteLine(); // Blank line for spacing
            Console.WriteLine("--Animal Summary--");
            Console.WriteLine($"Animal: {animalName}");
            Console.WriteLine($"Count: {animalCount}");
            Console.WriteLine($"Food per animal: {foodPerAnimal} lbs/day");
            Console.WriteLine($"Total daily food: {totalDailyFood} lbs");
            Console.WriteLine($"Total weekly food: {totalWeeklyFood} lbs");
        }
    }
}
