using SCollctions.Generic;
using System.Reflection.Metadata;
using System.Linq;
Console.WriteLine("welcome to my numbers program ");

Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

string numbers = Console.ReadLine();

int number = int.Parse(numbers);


List<int> numberlist;
numberlist = new List<int>();



do
{
    if (number != 0)
    {
        Console.WriteLine("please input your number");
        number = int.Parse(Console.ReadLine());
        numberlist.Add(number);



    }
}
