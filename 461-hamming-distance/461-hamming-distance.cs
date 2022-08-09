public class Solution {
    public int HammingDistance(int x, int y) {
        int result = 0;
            List<int> xtoDegit = new List<int>();
            List<int> ytoDegit = new List<int>();
            int xtoDegitCnt;
            int ytoDegitCnt;


            // 0이 아닌 조건 추가
            if (x != 0)
            {
                //x 2진수로.
                while (x != 1)
                {
                    xtoDegit.Add(x % 2);
                    x = x / 2;
                }
                xtoDegit.Add(1);
            }

            //0이 아닌 조건 추가.
            if (y != 0)
            {
                while (y != 1)
                {
                    ytoDegit.Add(y % 2);
                    y = y / 2;
                }
                ytoDegit.Add(1);
            }

            xtoDegitCnt = xtoDegit.Count;
            ytoDegitCnt = ytoDegit.Count;
            int maxDegitCnt = xtoDegitCnt > ytoDegitCnt ? xtoDegitCnt : ytoDegitCnt;

            //서로 사이즈 같게 만들어주고.
            if (xtoDegitCnt > ytoDegitCnt)
            {
                for (int i = 0; i < xtoDegitCnt - ytoDegitCnt; i++)
                {
                    ytoDegit.Add(0);
                }
            }
            else if (xtoDegitCnt < ytoDegitCnt)
            {
                for (int i = 0; i < ytoDegitCnt - xtoDegitCnt; i++)
                {
                    xtoDegit.Add(0);
                }
            }

            for (int i = 0; i < maxDegitCnt; i++)
            {
                if (xtoDegit[i] != ytoDegit[i])
                {
                    result++;
                }
            }

            return result;
    }
}