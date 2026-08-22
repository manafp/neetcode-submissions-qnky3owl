public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int product = 0;
        int zeroCount = 0;
        foreach(var num in nums)
        {
            if (num == 0 )
            {
                zeroCount ++;
                continue;
            }
            if(product == 0)
            {
                product = num;
            }
            else
            {
                product *= num; 
            }
            
        }
        var res = new int[nums.Length];
         if (zeroCount > 1)
            {
                return res;
            }
        for(int i=0;i<nums.Length; i++)
        {
            
             if(nums[i] == 0)
            {
                res[i] = product;
            } 
            else if(zeroCount >= 1)
            {
                res[i] = 0;
            }        
            else
            {
               res[i] = product / nums[i];
            }
        }

        return res;
    }
}
