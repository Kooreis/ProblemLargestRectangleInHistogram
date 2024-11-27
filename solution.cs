Here is a C# console application that solves the problem:

```csharp
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
        Console.WriteLine("The area of the largest rectangle is " + GetMaxArea(histogram, n));
    }

    static int GetMaxArea(int[] hist, int n)
    {
        Stack<int> s = new Stack<int>();
        int max_area = 0;
        int tp;
        int area_with_top;
        int i = 0;
        while (i < n)
        {
            if (s.Count == 0 || hist[s.Peek()] <= hist[i])
                s.Push(i++);
            else
            {
                tp = s.Peek();
                s.Pop();
                area_with_top = hist[tp] * (s.Count == 0 ? i : i - s.Peek() - 1);
                if (max_area < area_with_top)
                    max_area = area_with_top;
            }
        }
        while (s.Count > 0)
        {
            tp = s.Peek();
            s.Pop();
            area_with_top = hist[tp] * (s.Count == 0 ? i : i - s.Peek() - 1);
            if (max_area < area_with_top)
                max_area = area_with_top;
        }
        return max_area;
    }
}
```

This console application first asks the user to input the number of bars in the histogram and then the heights of the bars. It then calculates the area of the largest rectangle that can be formed within the histogram and prints it out. The calculation is done using a stack-based algorithm.