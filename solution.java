import java.util.Stack;

public class Main {
    public static void main(String[] args) {
        int[] histogram = {6, 2, 5, 4, 5, 1, 6};
        System.out.println("Maximum area is " + getMaxArea(histogram, histogram.length));
    }