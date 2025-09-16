using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Linq;
List<int> numberlist;
numberlist = new List<int>();
Console.WriteLine("welcome to my numbers program ");

Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

string numbers = Console.ReadLine();
        

int number = int.Parse(numbers);

numberlist.Add(number);

int numbercount = 1;



do
{
    if (number != 0)
    {
        Console.WriteLine("please input your number");
        number = int.Parse(Console.ReadLine());
        numberlist.Add(number);
        
    }
    numbercount = numbercount+1;
} while (number != 0);

    numbercount = numbercount-1;
    int total = numberlist.Sum();
    int average = total / numbercount;
    // int maximumnumber = numberlist.max();
    int largest = numberlist[0];
foreach (int n in numberlist)
{
    if (n > largest)
    {
        largest = n; 
    }
        
    }
    Console.WriteLine($"the nuber of times you guessed is {numbercount} times");
    Console.WriteLine($"your largest guessed number is {largest}");
    Console.WriteLine($"your average is {average:2f}");

    Console.WriteLine($"the sum of all numbers is {total}");