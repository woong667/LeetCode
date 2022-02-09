public class Solution {
    public void SortColors(int[] nums) {
        quickSort(0,nums.Length-1,ref nums);
    }
    
    public static void quickSort(int i,int j,ref int[] nums)
        {
            if (i >= j) return;
            int pivot = nums[(i + j) / 2];
            int left = i;
            int right = j;

            while(left<right)
            {
                while (nums[left] < pivot) left++;
                while (nums[right] > pivot) right--;
                           
                if(left<=right)
                {
                    swap(left, right, ref nums);
                    left++;right--;
                }
            }

            quickSort(i, right,ref nums);
            quickSort(left, j, ref nums);

        }
    
     public static void swap(int i,int j,ref int[] nums)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
        
}