public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
        var res = new List<List<int>>();

        for(int i = 0;i<=nums.Length - 3;i++)
        {
            if(nums[i] > 0 ) break;

            if(i>0 && nums[i] == nums[i-1]) continue;

            int l = i+1;
            int r = nums.Length - 1;
            while(l < r)
            {
                var sum = nums[i] + nums[l] + nums[r];
                if(sum == 0)
                {
                    res.Add(new List<int>(){nums[i],nums[l],nums[r]});
                    l++;
                    r--;
                    while(nums[l] == nums[l - 1] && l < r)
                    {
                        l++;
                    }

                }
                else if(l < r &&sum > 0)
                {
                    r--;
                } 
                else if(l < r && sum < 0)
                {
                    l++;
                }
            }
        
        }
        return res;
    }
}
