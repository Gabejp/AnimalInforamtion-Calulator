using System;

namespace AnimalInformationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Input Collection ---
            Console.WriteLine("--Animal Information Entry--");

            // 1. Prompt for animal name
            Console.Write("Enter animal name: ");
            string animalName = Console.ReadLine();

            // 2. Prompt for number of animals
            Console.Write($"Enter number of {animalName}'s: ");
            int count = Convert.ToInt32(Console.ReadLine());

            // 3. Prompt for food per animal in pounds
            Console.Write($"Enter pounds of food per {animalName} per day: ");
            double foodPerAnimal = Convert.ToDouble(Console.ReadLine());

            // --- Calculations ---
            // 4. Calculate total daily food requirement
            double totalDailyFood = count * foodPerAnimal;

            // 5. Calculate total weekly food requirement
            double totalWeeklyFood = totalDailyFood * 7;

            // --- Formatted Summary Output ---
            // 6. Display the calculated results
            Console.WriteLine("\n--Animal Summary--");
            Console.WriteLine($"Animal: {animalName}");
            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Food per animal: {foodPerAnimal} lbs/day");
            Console.WriteLine($"Total daily food: {totalDailyFood} lbs");
            Console.WriteLine($"Total weekly food: {totalWeeklyFood} lbs");
        }
    }
}
