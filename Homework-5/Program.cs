
double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];

Console.WriteLine("--- HOMEWORK SOLUTIONS ---\n");


double avg = Average(week);
Console.WriteLine($"1. Average Temperature: {avg:F1}\n");


double maxTemp = week[0];
int hottestDayIndex = 0;

for (int i = 1; i < week.Length; i++)
{
    if (week[i] > maxTemp)
    {
        maxTemp = week[i];
        hottestDayIndex = i;
    }
}
Console.WriteLine($"2. Hottest day: Day {hottestDayIndex + 1} ({maxTemp} °C)\n");


Console.WriteLine("3. Days warmer than average:");
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > avg)
    {
        Console.WriteLine($"   - Day {i + 1}: {week[i]} °C");
    }
}
Console.WriteLine();


Console.WriteLine("Bonus (Last three days - week[^3..]):");
var lastThreeDays = week[^3..];
foreach (var temp in lastThreeDays)
{
    Console.WriteLine($"   - {temp} °C");
}


static double Average(double[] t)
{
    double sum = 0;
    foreach (double val in t)
    {
        sum += val;
    }
    return sum / t.Length;
}
