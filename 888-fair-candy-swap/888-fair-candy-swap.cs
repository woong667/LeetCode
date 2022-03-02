public class Solution {
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) {
         int[] result = new int[2];
            int aliceSum = 0;
            int bobSum = 0;
            for(int i=0;i<aliceSizes.Length;i++)
            {
                aliceSum += aliceSizes[i];
            }
            for(int i=0;i<bobSizes.Length;i++)
            {
                bobSum += bobSizes[i];
            }

            for(int i=0;i<aliceSizes.Length;i++)  //3
            {
                int aliceNow = aliceSizes[i];
                for(int j=0;j<bobSizes.Length;j++) //5
                {
                    int bobNow = bobSizes[j];
                    if(aliceSum-aliceNow+bobNow==bobSum-bobNow+aliceNow)
                    {
                        result[0] = aliceNow;
                        result[1] = bobNow;
                        return result;
                    }
                }
            }
            return result;
    }
}