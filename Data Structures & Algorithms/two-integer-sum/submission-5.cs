public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      var dic = new Dictionary<int,int>();

      for(int i = 0;i<nums.Length;i++)
      {
        var index = target - nums[i];
        if(dic.ContainsKey(index))
        {
            return new int[]{dic[index],i};
        }
        dic[nums[i]] = i; 

      }

      throw new Exception("No solution");
    }
}
