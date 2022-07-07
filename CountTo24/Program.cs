// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 1; i < 5; ++i)
{
    Console.Write($"0");
    for (int j = i; j <= 24; j += i)
        Console.Write($", {j}");
    Console.WriteLine();
}