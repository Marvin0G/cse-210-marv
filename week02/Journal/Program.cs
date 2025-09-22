using System;
using System.Formats.Tar;
public class program
{
    static void Main(string[] args)
{
    Console.WriteLine("Hello World! This \n is the journal Project.");
    Console.WriteLine("what would you like to do");
    Console.WriteLine("1. write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    string selectedoption = Console.ReadLine();
    int selectednumber = int.Parse(selectedoption);
    string placeholdertext = "";
    // if (selectednumber == 1)
    // {
    //     journal.addentry(placeholdertext);
    // }
    // //     if else (selectednumber == 1)
    // // {
    // //     journal.addentry(placeholdertext);
    // // }



}
}

    






public class Entry
{
    public string date;
    public string prompt;
    public string response;

    public static void display()
    {

    }
}





public class journal
{
    private List<Entry> entries = new List<Entry>();
    public void addentry(Entry entry)
    {
        entries.Add(entry);
    }

    public void displayall()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry.date} - {entry.prompt} \n {entry.response} ");
        }
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




