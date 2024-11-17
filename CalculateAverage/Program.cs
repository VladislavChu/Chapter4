using System;



double average;
average = CalculateAverage(1, 2, 3, 4, 5.6, 7.3);
Console.WriteLine(average);

double[] data = { 4.3, 5.9, 2.6 };
average = CalculateAverage(data);
Console.WriteLine(average);



static double CalculateAverage(params double[] values)
{
    Console.WriteLine($"You sent me {values.Length} doubles.");

    double sum = 0;

    if (values.Length == 0)
    {
        return sum;
    }

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    return sum / values.Length;
}