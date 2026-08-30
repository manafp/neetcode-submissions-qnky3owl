public class Solution {
    public int Trap(int[] height) {
        int leftMax = height[0];
        int rightMax = height[height.Length - 1];

        int l = 0;
        int r = height.Length - 1;

        int maxWater = 0;

        while(l < r)
        {
           if(leftMax < rightMax)
           {
              l++;
              leftMax = Math.Max(leftMax,height[l]);
              maxWater +=  leftMax - height[l];
           }
           else
           {
             r--;
             rightMax = Math.Max(rightMax,height[r]);
             maxWater +=  rightMax - height[r];
           }
        }
        return maxWater;
    }
}


