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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        
      if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;
            List<int> pInList = new List<int>();
            List<int> qInList = new List<int>();
            List<int> pPreList = new List<int>();
            List<int> qPreList = new List<int>();
            List<int> pPostList = new List<int>();
            List<int> qPostList = new List<int>();
            Inorder(p, ref pInList);
            Inorder(q, ref qInList);
            PreOrder(p, ref pPreList);
            PreOrder(q, ref qPreList);
            PostOrder(p,ref pPostList);
            PostOrder(q,ref qPostList);
            return pInList.SequenceEqual(qInList) && pPreList.SequenceEqual(qPreList) && pPostList.SequenceEqual(qPostList);
    }
     public static void Inorder(TreeNode tn, ref List<int> list)
        {
            if (tn.left != null)
            {
                Inorder(tn.left, ref list);
            }
            else
            {
                list.Add(-10001);
            }
            list.Add(tn.val);
            if (tn.right != null)
            {
                Inorder(tn.right, ref list);
            }
            else
            {
                list.Add(-10001);
            }
        }
        public static void PreOrder(TreeNode tn, ref List<int> list)
        {

            list.Add(tn.val);
            if (tn.left != null)
            {
                PreOrder(tn.left, ref list);
            }
            else
            {
                list.Add(-10001);
            }
            if (tn.right != null)
            {
                PreOrder(tn.right, ref list);
            }
            else
            {
                list.Add(-10001);
            }
        }

        public static void PostOrder(TreeNode tn, ref List<int> list)
        {
            if (tn.left != null)
            {
                PostOrder(tn.left, ref list);
            }
            else
            {
                list.Add(-10001);
            }
            if (tn.right != null)
            {
                PostOrder(tn.right, ref list);
            }
            else
            {
                list.Add(-10001);
            }
            list.Add(tn.val);
        }
}