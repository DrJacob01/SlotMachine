using System;
using System.Linq;
using System.Threading;

class Program
{
    static int point = 3;
    static string[] fruitList = { "Apple", "Blueberry", "Carrot" };
    static Random dice = new Random(); // create a variable called dice, this is a random variable.

    static void Main()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Are you ready to spin?");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
        Thread.Sleep(1000);

        string[] spins = new string[3]; // Store the results of each spin

        for (int i = 0; i < 3 && point > 0; i++) // Loop for three spins
        {
            string randPicker = fruitList[dice.Next(0, 3)]; // Pick a random fruit from the list
            spins[i] = randPicker; // Store the result of the current spin
            DisplayColoredFruit(randPicker); // Display the randomly picked fruit in color
            Thread.Sleep(1000);
        }

        if (spins.All(s => s == spins[0])) // Check if all spins are the same
        {
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Yipee, you won! Now cashout before you lose it all!");
            Console.ForegroundColor = ConsoleColor.White;
            pointPlus(); // Increment points if all spins match
        }
        else
        {
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Womp, womp. 98% of gamblers quit before they win big!");
            Console.ForegroundColor = ConsoleColor.White;
            pointMinus(); // Decrement points if spins do not match
        }
    }

    static void DisplayColoredFruit(string fruit)
    {
        switch (fruit)
        {
            case "Apple":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "Blueberry":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case "Carrot":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                break;
                // Add more cases for additional fruits and colors as needed
        }

        Console.WriteLine(fruit);

        // Reset the console color to default
        Console.ResetColor();
    }

    static void pointMinus()
    {
        point--;
        Console.WriteLine($"Points remaining: {point}");
    }

    static void pointPlus()
    {
        point++;
        Console.WriteLine($"Points remaining: {point}");
    }
}
