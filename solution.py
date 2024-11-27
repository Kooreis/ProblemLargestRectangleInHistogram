Here is a Python solution for finding the largest rectangle in a histogram. This solution uses a stack to keep track of the heights of the bars in the histogram and their positions. 

```python
def largestRectangleArea(heights):
    stack = []
    max_area = 0

    for i, h in enumerate(heights):
        start = i
        while stack and stack[-1][1] > h:
            index, height = stack.pop()
            max_area = max(max_area, height * (i - index))
            start = index
        stack.append((start, h))

    for start, height in stack:
        max_area = max(max_area, height * (len(heights) - start))

    return max_area

def main():
    heights = [int(x) for x in input("Enter the heights of the bars in the histogram separated by space: ").split()]
    print("The area of the largest rectangle is: ", largestRectangleArea(heights))

if __name__ == "__main__":
    main()
```

This console application will prompt the user to enter the heights of the bars in the histogram separated by space. It will then calculate and print the area of the largest rectangle that can be formed within the histogram.