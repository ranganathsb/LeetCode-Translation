Code Definition:
/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MinDepth(TreeNode root) {
        
    }
}

Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      TreeNode root = __TreeNodeUtils__.deserialize(line);
      file.WriteLine(__Serializer__.serialize(new Solution().MinDepth(root)));
    }
  }
  }
}


ac Solution Code:
public class Solution {
    public int MinDepth(TreeNode root) {
        if(root==null) return 0;
        if(root.left==null || root.right==null)
            return 1+Math.Max(MinDepth(root.left),MinDepth(root.right));
        return 1+Math.Min(MinDepth(root.left),MinDepth(root.right));
    }
}

    
public class Solution {
    private void Swap<T>(ref T a, ref T b){
        T temp = a;
        a=b;
        b=temp;
    }
    
    public int MinDepth(TreeNode root) {
        //Iterative BFS
        if(root==null) return 0;
        Queue<TreeNode> curr = new Queue<TreeNode>();
        Queue<TreeNode> next = new Queue<TreeNode>();
        int depth=1;
        curr.Enqueue(root);
        while(curr.Count!=0){
            TreeNode temp = curr.Dequeue();
            if(temp.left==null&&temp.right==null) break;
            if(temp.left!=null) next.Enqueue(temp.left);
            if(temp.right!=null) next.Enqueue(temp.right);
            if(curr.Count==0){
                depth++;
                Swap(ref curr, ref next);
            }
        }
        return depth;
    }
}

