public class Solution {
    public bool IsPathCrossing(string path) {
        bool result = false;
            Dictionary<Tuple<int, int>, bool> dic = new Dictionary<Tuple<int, int>, bool>();
            dic.Add(new Tuple<int, int>(0,0), true);
            int nowX = 0;
            int nowY = 0;

            for (int i=0;i<path.Length;i++)
            {
                char now = path[i];
                if(now.Equals('N')) //위로
                {
                    nowY += 1;
                }
                else if(now.Equals('S')) //아래로
                {
                    nowY -= 1;
                }
                else if(now.Equals('W')) //왼쪽으로
                {
                    nowX -= 1;
                }
                else  //오른쪽으로
                {
                    nowX += 1;
                }

                if(dic.ContainsKey(new Tuple<int, int>(nowX,nowY)))
                {
                    result = true;
                    break;
                }
                else
                {
                    dic.Add(new Tuple<int, int>(nowX, nowY), true);
                }
                
            }

            return result;
    }
}