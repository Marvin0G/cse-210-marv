Console.Write("please innput your grade-percentage: ");
string gradepercent = Console.ReadLine();
int gradenumber = int.Parse(gradepercent);
string grade = "";

if (gradenumber >= 90)
{
    grade = "A";
}
else if (gradenumber >= 80)
{
    grade = "B";
}

else if (gradenumber >= 70)
{
    grade = "C";
}

else if (gradenumber >= 60)
{
    grade = "D";
}

else if (gradenumber < 60)
{
    grade = "F";
}

Console.WriteLine($"your grade is {grade}" );


if (gradenumber < 70)
{
    Console.WriteLine("im sorry you didn't pass but cheer up thers always nextime to do better.");
}