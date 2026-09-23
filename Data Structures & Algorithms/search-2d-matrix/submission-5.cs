public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
         int l = 0;
         int r = matrix.Length - 1;
         
         while(l <= r)
         {
            int mid = (l + r) / 2;

            if(matrix[mid][0] == target)return true;
            if(target > matrix[mid][0] && target < matrix[mid][matrix[mid].Length - 1])
            {
                 l = 0;
                 r = matrix[mid].Length - 1;

                while(l <= r)
                {
                   int imid = (l + r) / 2;

                   if(matrix[mid][imid] == target) return true;
                   if(matrix[mid][imid] < target) l = imid + 1;
                   else r = imid - 1;
                }
                break;
            }
            if(target < matrix[mid][0]) r = mid - 1;
            else l = mid + 1;
         }  

         return false;
    }
}
