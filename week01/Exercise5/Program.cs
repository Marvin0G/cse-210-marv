using System;
using System.Runtime.CompilerServices;


        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void Displaywelcome()
        {
           Console.WriteLine("welcome to my program");
            
        }

        static string Promptusername()
        {
            Console.Write("please input your name: ");
            string name = Console.ReadLine();
            // int favnumber = int.Parse(fnumber);
            return name;

        }

        static int Promptusernumber()
        {
            Console.Write("please input your favourite number: ");
            string fnumber = Console.ReadLine();
            int favnumber = int.Parse(fnumber);
            return favnumber;

        }

        static int Squarenumber(int numb)
        {
            int squareonumber = numb * numb ;
            return squareonumber;
        }
        static void Displayresult(string name, int sqnumb)
        {
            Console.WriteLine($"your name is {name} and the square of your favorite number is {sqnumb}");
        }

        // static void Main()
        // {

            
        // }

    
    static void Main()
{
    Displaywelcome();
    string tname = Promptusername();
    int number = Promptusernumber();
    int bsqnumb = Squarenumber(number);
    Displayresult(tname, bsqnumb);
}
Main();