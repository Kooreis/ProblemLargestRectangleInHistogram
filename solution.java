Here is a Java console application that solves the problem:

```java
import java.util.Stack;

public class Main {
    public static void main(String[] args) {
        int[] histogram = {6, 2, 5, 4, 5, 1, 6};
        System.out.println("Maximum area is " + getMaxArea(histogram, histogram.length));
    }

    static int getMaxArea(int hist[], int n) {
        Stack<Integer> s = new Stack<>();
        int max_area = 0;
        int tp;
        int area_with_top;
        int i = 0;
        while (i < n) {
            if (s.empty() || hist[s.peek()] <= hist[i])
                s.push(i++);
            else {
                tp = s.peek();
                s.pop();
                area_with_top = hist[tp] * (s.empty() ? i : i - s.peek() - 1);
                if (max_area < area_with_top)
                    max_area = area_with_top;
            }
        }
        while (s.empty() == false) {
            tp = s.peek();
            s.pop();
            area_with_top = hist[tp] * (s.empty() ? i : i - s.peek() - 1);
            if (max_area < area_with_top)
                max_area = area_with_top;
        }
        return max_area;
    }
}
```

This program uses a stack to keep track of the indices of the bars in the histogram. It calculates the area of the largest rectangle by considering each bar as the smallest bar in the rectangle. The area of the rectangle is then calculated by multiplying the height of the smallest bar by the width of the rectangle. The width of the rectangle is determined by the position of the next smaller bar on the left and the position of the next smaller bar on the right. The maximum area of all these rectangles is then returned as the result.