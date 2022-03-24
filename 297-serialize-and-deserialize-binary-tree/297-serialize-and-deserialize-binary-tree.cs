/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
         Queue<TreeNode> queue = new Queue<TreeNode>();
            string serializeString = "[";

            if(root==null)
            {
                return "[]";
            }
            else
            {
                serializeString += (root.val).ToString();
            }
        
            queue.Enqueue(root);
            while(queue.Count!=0)
            {
                TreeNode now = queue.Dequeue();

                serializeString += ",";

                if (now.left!=null)
                {
                    queue.Enqueue(now.left);
                    serializeString += (now.left.val).ToString();
                }
                else
                {
                    serializeString += "null";
                }

                serializeString += ",";
                if (now.right!=null)
                {
                    queue.Enqueue(now.right);
                    serializeString += (now.right.val).ToString();
                }
                else
                {
                    serializeString += "null";
                }

            }
            serializeString += "]";
            return serializeString;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        List<int> TreeList = getIntList(data);
         if(TreeList.Count==0)
            {
                return null;
            }
            int idx = 0;
            TreeNode root=new TreeNode(TreeList[idx++]);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count!=0)
            {
                TreeNode temp = queue.Dequeue();
                if(TreeList[idx]!=-1001)
                {
                    TreeNode left = new TreeNode(TreeList[idx]);
                    temp.left = left;
                    queue.Enqueue(left);

                }
   
                idx++;
                if(TreeList[idx]!=-1001)
                {
                    TreeNode right  = new TreeNode(TreeList[idx]);
                    temp.right = right;
                    queue.Enqueue(right);
                }
               
                idx++;

            }
          
            
            return root;
    }
    public static List<int> getIntList(string data)
        {
            List<int> TreeList = new List<int>();
        if (data == "[]")
                return TreeList;
            string temp = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '[')
                    continue;
                else if ((data[i] == ',' && !string.IsNullOrEmpty(temp)) || data[i] == ']')
                {
                    if (temp == "null")
                    {
                        TreeList.Add(-1001);
                        temp = "";
                    }
                    else
                    {
                        TreeList.Add(Int32.Parse(temp));
                        temp = "";
                    }
                }
                else
                {
                    temp += data[i];
                }

            }
            return TreeList;
        }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));