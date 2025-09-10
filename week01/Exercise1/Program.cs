Console.Write("what is your first name? ");
string firstname = Console.ReadLine();

Console.Write("what is your last name? ");
string lastname = Console.ReadLine();

string bond_intro = ($"your name is {lastname}, {firstname} {lastname}.");

Console.WriteLine($"{bond_intro}");