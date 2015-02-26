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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        
    }
}


Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      string[] input = line.Split();
      TreeNode p = __TreeNodeUtils__.deserialize(input[0]);
      TreeNode q = __TreeNodeUtils__.deserialize(input[1]);
      file.WriteLine(__Serializer__.serialize(new Solution().IsSameTree(p,q)));
    }
  }
  }
}


ac Solution Code:
public class Solution {
		public bool IsSameTree(TreeNode p, TreeNode q) {
			if (p == null && q == null)
				return true;
			if (p == null || q == null) 
				return false;
			return p.val == q.val 
			&& IsSameTree (p.left, q.left) 
			&& IsSameTree (p.right, q.right);
		}
}
