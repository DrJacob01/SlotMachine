using System.Linq;
String[] fruitList = {"Apple", "Blueberry", "Carrot"};

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Are you ready to spin?");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
Thread.Sleep(1000);


Random dice = new Random();     //create a var called dice, this is a random var thingy.

for (int i = 0; i < 3; i++) // Loop for three spins
{
    string randPicker = fruitList[dice.Next(0, 3)]; // Pick a random fruit from the list
    Console.WriteLine(randPicker);  // Display the randomly picked fruit
    Thread.Sleep(1000);
}
