using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of bars in the histogram:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] histogram = new int[n];
        Console.WriteLine("Enter the heights of the bars:");
        for (int i = 0; i < n; i++)
        {
            histogram[i] = Convert.ToInt32(Console.ReadLine());
        }
    }