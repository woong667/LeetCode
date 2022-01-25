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
        public IList<int> InorderTraversal(TreeNode root) {
            
            IList<int> list = new List<int>();
            recursion_inorder(root, ref list);
            return list;
        }
    
     public static void recursion_inorder(TreeNode root,ref IList<int> list)
        {

            if (root == null)
                return;

            //왼쪽 노드 재귀함수 실행
            recursion_inorder(root.left,ref list);

            //자신 데이터 출력
            list.Add(root.val);

            //오른쪽 노드 재귀함수 실행
            recursion_inorder(root.right,ref list);
        }
}