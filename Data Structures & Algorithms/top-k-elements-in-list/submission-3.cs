public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

     var dict = new Dictionary<int, int>();
 foreach (var num in nums)
 {

     dict[num] = dict.GetValueOrDefault(num, 0) + 1;
 }
 var heap = new PriorityQueue<int, int>();
 foreach (var kp in dict)
 {
     heap.Enqueue(kp.Key, kp.Value);
     if (heap.Count > k)
     {
         heap.Dequeue();
     }
 }
 var array = new int[k];
 for(int i = 0;i<k;i++)
 {
     array[i] = heap.Dequeue();
 }
 return array;
    }
}
