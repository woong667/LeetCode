public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int result = 0;
            int rowCount = grid.Length;
            int colCount = grid[0].Length;
            for(int i=0;i<rowCount-2;i++)
            {
                for(int j=0;j<colCount-2;j++)
                {
                    if(checkMagicSquare(ref grid,i,j))
                    {
                        result++;
                    }
                }
            }
            return result;
    }
    
    public static bool checkMagicSquare(ref int[][] grid,int row,int col)
        {
            bool result = false;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<=2;i++)
            {
                for(int j=0;j<=2;j++)
                {
                   if(grid[row+i][col+j]>9||grid[row+i][col+j]<1)
                    {
                        return false;
                    }
                    else if(!dic.ContainsKey(grid[row+i][col+j]))
                    {
                        dic[grid[row+i][col+j]] = 1;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            int firstRow = grid[row][col] + grid[row][col + 1] + grid[row][col + 2];
            int secondRow= grid[row+1][col] + grid[row+1][col + 1] + grid[row+1][col + 2];
            int thirdRow= grid[row+2][col] + grid[row+2][col + 1] + grid[row+2][col + 2];
            int firstCol = grid[row][col] + grid[row + 1][col] + grid[row + 2][col];
            int secondCol= grid[row][col+1] + grid[row + 1][col+1] + grid[row + 2][col+1];
            int thirdCol= grid[row][col+2] + grid[row + 1][col+2] + grid[row + 2][col+2];
            int leftRight = grid[row][col] + grid[row + 1][col + 1] + grid[row + 2][col + 2];
            int rightLeft = grid[row][col + 2] + grid[row + 1][col + 1] + grid[row + 2][col];

            if((firstRow==secondRow)&&(firstRow==thirdRow)&&(firstRow==firstCol)&&(firstRow==secondCol)&&(firstRow==thirdCol)&&(firstRow==leftRight)&&(firstRow==rightLeft))
            {
                result = true;
                return result;
            }
            return result;
        }
}