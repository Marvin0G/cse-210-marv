Console.WriteLine("hello and welcome to our number guessig game powered by c#");
Console.WriteLine("What is the magic number: ");

string guess_number = Console.ReadLine();

int number = int.Parse(guess_number);

Random randomGenerator = new Random();
int magicnumber =randomGenerator.Next(0, 100) ;
int guesscount = 1;


while (number != magicnumber)
{
    guesscount++;
    if (number < magicnumber)
    {
        Console.WriteLine("guess higher");
        Console.WriteLine("what is your guess: ");
        number = int.Parse(Console.ReadLine());

    }
    else if (number > magicnumber)
    {
        Console.WriteLine("guess lower");
        Console.WriteLine("what is your guess: ");
        number = int.Parse(Console.ReadLine());

    }
    else if (number == magicnumber)
    {
        Console.WriteLine("congratulations you guessed correctly");
    }
    else
    {
        Console.WriteLine("please put in a valid input");
        Console.WriteLine("what is your guess: ");
        number = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine($"you guessed {guesscount} times");

