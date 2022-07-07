int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Guess a number");
int guessedNumber = 0;
while (correctNumber != guessedNumber)
{
    guessedNumber = int.Parse(Console.ReadLine());
    if (correctNumber == guessedNumber)
        Console.WriteLine("Yay");
    else
        Console.WriteLine("Wrong");
}