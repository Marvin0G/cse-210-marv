using System;

static void Main(string[] args)
{
    Console.WriteLine("Hello World! This \n is the journal Project.");
    Console.WriteLine("what would you like to do");
    Console.WriteLine("1. write");
    Console.WriteLine("1. Display");
    Console.WriteLine("1. Load");
    Console.WriteLine("1. Save");
    Console.WriteLine("1. Quit");
    string selectedoption = Console.ReadLine();
    int selectednumber = int.Parse(selectedoption);
    string placeholdertext = "";
    if (selectednumber == 1)
    {
        journal.addentry(placeholdertext);
    }
    //     if else (selectednumber == 1)
    // {
    //     journal.addentry(placeholdertext);
    // }




}
    

    static void hello()
{
    Console.WriteLine("Hello World! This is the done Project.");
}


hello();




public class Entry
{
    public int date;
    public string prompt;
    public string response;

    public static void display()
    {

    }
}





public class journal
{
    public static void addentry(string entry)
    {

    }

    public static void displayall()
    {

    }

    public static void savetofile(string filename)
    {

    }


    public static void loadfromfile(string filename)
    {

    }
}


public class promptgenerator
{
    public static void getrandomprompt()
    {

    }
}




