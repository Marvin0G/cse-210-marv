using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {   Journal myjournal = new Journal();
        Promptgenerator generator = new Promptgenerator();

        while (true)
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


            if (selectednumber == 1)
            {
                string prompt1243 = generator.getrandomprompt();
                Console.WriteLine(prompt1243);
                string response = Console.ReadLine();

                Entry newEntry = new Entry(prompt1243, response);
                myjournal.Addentry(newEntry);
            }

            else if (selectednumber == 2)
            {
                myjournal.displayall();
            }
            else if (selectednumber == 3)
            {
                Console.Write("enter name of file to be loaded");
                string filename = Console.ReadLine();
                myjournal.loadfromfile(filename);
            }
            else if (selectednumber == 4)
            {
                Console.Write("enter file name to be saved ");
                string filename2 = Console.ReadLine();
                myjournal.savetofile(filename2);
            }
            else if (selectednumber == 5)
            {
                Console.WriteLine("Goodbye");
                break;
            }
        }



}
}

    






public class Entry
{
    public string date { get; set; }
    public string prompt { get; set; }
    public string response { get; set; }

    public Entry(string prompt, string response)
    {
    this.date = DateTime.Now.ToString("yyyy-MM-dd");
    this.prompt = prompt;
    this.response = response; 
    }

    public static void display()
    {
        Console.WriteLine("");
    }
}





public class Journal
{
    private List<Entry> entries = new List<Entry>();
    public void Addentry(Entry entry)
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

    public void savetofile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                writer.WriteLine($" {e.date} | {e.prompt}| {e.response}| ");
            }
        }
        Console.WriteLine($" saved {entries.Count} to {filename}");
    }


    public void loadfromfile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("file was not found");
            return;
        }
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = string.Join("|", parts, 2, parts.Length - 2);

                Entry e = new Entry(prompt, response);
                e.date = date;
                entries.Add(e);



            }
        }
        Console.WriteLine($"loaded {entries.Count} entries from {filename}");
        
    }
}


public class Promptgenerator
{
    private List<string> prompt = new List<string>()
    {
        "what made you smile today?",
        "whats something you learned today?",
        "How did you see God's hand in your life today?"

    };
    private Random random = new Random();
    public string getrandomprompt()
    {
        int index = random.Next(prompt.Count);
        return prompt[index];
    }
}




