using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static string displaywelcome()
        {
            Console.WriteLine("welcome to my program");

        }

        static string promptusername()
        {
            Console.Write("please input your name");
            string name = Console.ReadLine();
            // int favnumber = int.Parse(fnumber);
            return name;

        }

        static int promptusernumber()
        {
            Console.Write("please input your favourite number");
            string fnumber = Console.ReadLine();
            int favnumber = int.Parse(fnumber);
            return favnumber;

        }

        static int squarenumber(int numb)
        {
            int squareonumber = numb ^ 6;
            return squareonumber;
        }
        static void displayresult(string name, int sqnumb)
        {
            Console.WriteLine($"your name is {name} and the square of your favorite number is  {sqnumb}");
        }

    }
}