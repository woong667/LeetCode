public class Solution {
    public void DuplicateZeros(int[] arr) {
        
            for(int i=0;i<arr.Length-1;i++)
            {
                int tmp = arr[i];
                if(tmp==0)
                {
                    int k = arr.Length - 1;
                    while (k-1>i)
                    {
                        arr[k] = arr[k - 1];
                        k--;
                    }
                    arr[k] = 0;
                    i++;
                }
                
            }
    }
}