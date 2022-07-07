// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime current=DateTime.Now;

DateTime morishimaBirthday = new DateTime(1999, 12, 29);

TimeSpan days = current.Subtract(morishimaBirthday);
double daysToNextAnniversary = 10000-(days.TotalDays%10000);

Console.WriteLine("Days since born: {0}", days.TotalDays);
Console.WriteLine("Days to next anniversary: {0}", daysToNextAnniversary);
