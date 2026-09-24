public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
       
       int l = 1;
       int r = piles.Max();
       int min = r;
       while(l <= r)
       {
         var mid = (l + r) / 2;
         int hour = 0;
         for(int i=0;i<piles.Length;i++)
         {
             hour = hour + (int)Math.Ceiling((double)piles[i] / mid);
         }
         if(hour <= h) 
         {
            r = mid - 1;
            min = Math.Min(mid,min);
         }
         else l = mid + 1;
       }

       return min;
    }
}
