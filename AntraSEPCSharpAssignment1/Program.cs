// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string inStr = null;
ulong input = 1;
while (inStr == null)
{
    Console.Write("Input: ");
    inStr = Console.ReadLine();
    try
    {
        input = ulong.Parse(inStr);
    }
    catch (Exception)
    {
        Console.WriteLine("invalid input");
        inStr = null;
    }
}
ulong[] conversion = new ulong[9] { 1, 100, 36524, 876576, 52594560, 3155673600, 3155673600000, 3155673600000000, 3155673600000000000 };
int a = 0;
Console.WriteLine($"Output: {input * conversion[a++]} centries = {input * conversion[a++]} years = {input * conversion[a++]} days = " +
    $"{input * conversion[a++]} hours = {input * conversion[a++]} minutes = {input * conversion[a++]} seconds = " +
    $"{input * conversion[a++]} milliseconds = {input * conversion[a++]} microseconds ={input * conversion[a++]} nanoseconds");