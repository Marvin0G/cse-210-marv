using SCollctions.Generic;
using System.Reflection.Metadata;
Console.WriteLine("welcome to my numbers program ");

Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

string numbers = Console.ReadLine();

int number = int.Parse(numbers);


List<int> numberlist;
numberlist = new List<int>();

numberlist.Add(number);

while (number != 0)
{
    if (number != 0)
    {
        Console.WriteLine("Enter number");
        number = int.Parse(Console.ReadLine());
        numberlist.Add(number);
        



    }
}
int total = numberlist.Sum();
Console.WriteLine($"the sum of all your input is{total} 😊😊");