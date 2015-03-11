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
    public bool IsValidBST(TreeNode root) {
        
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
      file.WriteLine(__Serializer__.serialize(new Solution().IsValidBST(root)));
    }
  }
  }
}

ac Solution Code:
public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root==null)
            return true;
        object prev=null; //use object to box int value
        return IsValidBSTHelper(root,ref prev);
    }
    private bool IsValidBSTHelper(TreeNode root,ref object prev){ //pass by reference
        if(root == null) return true;
        if(IsValidBSTHelper(root.left,ref prev)){
            if(prev==null || root.val>(int)prev){
                prev = root.val;
                return IsValidBSTHelper(root.right,ref prev);
            }
            return false;
        }
        return false;
    }
}

ac Solution Code:
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return IsValidBSTHelper(root, null, null); 
    }
    
    private bool IsValidBSTHelper(TreeNode p, object low, object high) {
        if (p == null) return true;
        return (low == null || p.val > (int)low) && (high == null || p.val < (int)high)
            && IsValidBSTHelper(p.left, low, (object)p.val)
            && IsValidBSTHelper(p.right, (object)p.val, high);
    }
}
