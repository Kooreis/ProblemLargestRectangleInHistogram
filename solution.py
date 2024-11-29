for start, height in stack:
        max_area = max(max_area, height * (len(heights) - start))

    return max_area