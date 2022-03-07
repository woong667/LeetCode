public class Solution {
    public bool JudgeCircle(string moves) {
         Dictionary<char, Tuple<int,int>> dic = new Dictionary<char,Tuple<int,int>>();
            dic.Add('L', new Tuple<int, int>(-1,0));
            dic.Add('R', new Tuple<int, int>(1, 0));
            dic.Add('U', new Tuple<int, int>(0, 1));
            dic.Add('D', new Tuple<int, int>(0,-1));
            int x = 0;
            int y = 0;
            for(int i=0;i<moves.Length;i++)
            {
                char now = moves[i];
                x += dic[now].Item1;
                y += dic[now].Item2;
            }
            if (x == 0 && y == 0)
                return true;
            else
                return false;
    }
}