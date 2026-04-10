public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int i = 0;
        int j = heights.Length - 1;
        while(i < j)
        {
            int area = (j-i) * Math.Min(heights[i],heights[j]);
            max = Math.Max(max,area);
            if(heights[i] <= heights[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return max;
    }
}
