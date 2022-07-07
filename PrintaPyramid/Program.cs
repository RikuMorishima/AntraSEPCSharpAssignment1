// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter height: ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    int side = height - 1 - i;
    int middle = 1 + 2 * i;
    for (int j = 0; j < side; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < middle; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < side; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}