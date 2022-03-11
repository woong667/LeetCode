public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
          Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
            bool[] check = new bool[numCourses];
            Queue<int> q = new Queue<int>();

            //자기한테 몇개의 노드가 오는지 기록할 arr
            int[] sonCnt = new int[numCourses];
            
            foreach(int[] arr in prerequisites)
            {
                int preValue = arr[0];
                int nextValue = arr[1];
                check[preValue] = true;
                check[nextValue] = true;
                //key 있으면
                if(adj.ContainsKey(preValue))
                {
                    adj[preValue].Add(nextValue);
                }
                else
                {
                    List<int> subList = new List<int>();
                    subList.Add(nextValue);
                    adj[preValue] = subList;
                }
                sonCnt[nextValue] += 1;
               
            }
            //인접리스트로 그래프 구현.

            //자신에게 오는 간선이 없는 노드들을 큐에 삽입해준다. 1Cycle 
            for(int i=0;i< numCourses; i++)
            {
                if(sonCnt[i]==0&&check[i])
                {
                    q.Enqueue(i);
                }
            }

            while (!(q.Count == 0))
            {
                int now = q.Dequeue();
                if (adj.ContainsKey(now))
                {
                    for (int i = 0; i < adj[now].Count; i++)
                    {
                        sonCnt[adj[now][i]]--;  //자신에게 오는 간선을 지워주는중.
                        if (sonCnt[adj[now][i]] == 0&&check[adj[now][i]])
                        {
                            q.Enqueue(adj[now][i]);
                        }
                    }
                }
            }

            

            for(int i=0;i<sonCnt.Length;i++)
            {
                if(sonCnt[i]>0)
                {
                    return false;
                }
            }

            return true;
    }
}