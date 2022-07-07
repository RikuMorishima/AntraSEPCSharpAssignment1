// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime thisDate = DateTime.Now;
if (thisDate.Hour >= 0 && thisDate.Hour < 10)
    Console.WriteLine("Good Morning");
if (thisDate.Hour >= 10 && thisDate.Hour < 16)
    Console.WriteLine("Good Afternooon");
if (thisDate.Hour >= 16 && thisDate.Hour < 21)
    Console.WriteLine("Good Evening");
if (thisDate.Hour >= 21 && thisDate.Hour < 24)
    Console.WriteLine("Good night");