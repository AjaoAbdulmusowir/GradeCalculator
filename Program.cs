Console.Write("Hello!");
Console.WriteLine();
Console.Write("Enter your score: ");
bool userInput = int.TryParse(Console.ReadLine(), out int value);
while (userInput == false)
{
    Console.WriteLine("Read the instruction above");
    Console.Write("Enter a number : ");
    userInput = int.TryParse(Console.ReadLine(), out value);   
}

if ( value >= 90)
{
    Console.WriteLine("Awesome! Your grade is 'A'");
}
else if (value >= 80)
{
    Console.WriteLine("Great! Your grade is 'B'");
}
else if (value >= 70)
{
    Console.WriteLine("Good! Your grade is 'C'");
}
else if (value >= 60)
{
    Console.WriteLine("Thank you! Your grade is 'D'");
}
else if (value <= 59)
{
    Console.WriteLine("Thank You! Your grade is 'F'");
}
else 
{
    Console.WriteLine("Sorry! Enter a number between 1-100");
}

