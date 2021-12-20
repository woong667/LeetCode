/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
            TreeNode nowNode = new TreeNode();
            IList<IList<int>> list = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            //root가 없을때를 대비
            if (root != null)
            {
                queue.Enqueue(root);
            }
            else
            {
                return list;
            }
            ////////////////////////
           
         
            bool right = true;
            while (queue.Count!=0)
            {
                List<int> subList = new List<int>();
                int queueSize = queue.Count;
                for (int i=0;i< queueSize; i++)  // 한개의 level
                {
                    nowNode = queue.Dequeue();
                    if (nowNode.left != null) //null이 아니면 넣고 아니면 말기
                    {
                        queue.Enqueue(nowNode.left);
                      
                    }
                    if(nowNode.right!=null)  //null이 아니면 넣고 아니면 말기
                    {
                        queue.Enqueue(nowNode.right);
                    }
                    subList.Add(nowNode.val);
                }
                if (!right)
                    subList.Reverse();

                list.Add(subList);
                right = !right;
           
            }

            return list;
    }
}