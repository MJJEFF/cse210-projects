using System.Collections.Generic;

List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int number;

do
{
    Console.Write("Enter number: ");
    number = int.Parse(Console.ReadLine());

    if (number != 0)
    {
        numbers.Add(number);
    }

} while (number != 0);

int sum = 0;

foreach (int value in numbers)
{
    sum += value;
}

double average = (double)sum / numbers.Count;

int largest = numbers[0];

foreach (int value in numbers)
{
    if (value > largest)
    {
        largest = value;
    }
}

Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {average}");
Console.WriteLine($"The largest number is: {largest}");