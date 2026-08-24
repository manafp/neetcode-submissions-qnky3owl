public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();
        foreach(var num in nums)
        {
            set.Add(num);
        }
        var max = 0;
        while(set.Count > 0)
        {
            var num = set.First();
            int count = 0;
            int i = num;
            while(nums.Contains(i))
            {
                set.Remove(i);
                count++;
                i--;
            }
            i = num + 1;
            while(nums.Contains(i))
            {
                set.Remove(i);
                count++;
                i++;
            }

            max = Math.Max(max,count);

        }

        return max;
    }
}
