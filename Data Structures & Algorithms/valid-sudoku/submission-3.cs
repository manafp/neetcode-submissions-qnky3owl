public class Solution {
    public bool IsValidSudoku(char[][] board) {
   
        for(int i = 0;i<9;i++)
        {
            var set = new HashSet<int>();
            for(int j=0;j<9;j++)
            {
                if(board[i][j] != '.' &&!set.Add(board[i][j]))
                {
                    return false;
                }
            }
        }

        for(int i = 0;i<9;i++)
        {
            var set = new HashSet<int>();
            for(int j=0;j<9;j++)
            {
                if(board[j][i] != '.' && !set.Add(board[j][i]))
                {
                    return false;
                }
            }
        }

        for(int i = 0;i<9;i++)
        {
            int row = (i / 3) * 3;
            int col = (i % 3) * 3;
            var set  = new HashSet<int>();
            for(int j = row;j < row + 3;j++)
            {
                for(int k = col;k<col+3;k++)
                {
                    if(board[j][k] != '.'&&!set.Add(board[j][k]))
                    {
                        return false;
                    }
                }
            } 
        }
        return true;
    }
}





