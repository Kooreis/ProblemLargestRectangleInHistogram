static int getMaxArea(int hist[], int n) {
        Stack<Integer> s = new Stack<>();
        int max_area = 0;
        int tp;
        int area_with_top;
        int i = 0;