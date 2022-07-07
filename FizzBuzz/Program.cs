int max = 100;
for (int i = 0; i < max; ++i)
{
    if (i % 3 == 0 && i % 5 != 0)
        Console.WriteLine("/fizz");
    else if (i % 5 == 0 && i % 3 != 0)
        Console.WriteLine("/buzz/");
    else if (i % 5 == 0 && i % 3 == 0)
        Console.WriteLine("/fizzbuzz/");
    else
        Console.WriteLine(i);
}
