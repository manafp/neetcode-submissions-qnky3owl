public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashSet = new HashSet<int>(nums);

        return hashSet.Count != nums.Length;
    }
}