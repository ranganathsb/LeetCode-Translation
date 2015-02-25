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
    public TreeNode SortedArrayToBST(int[] num) {
        
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
      int[] num = input.Skip(1).Select(y => int.Parse(y))
                       .ToArray();
      file.WriteLine(__Serializer__.serialize(new Solution().SortedArrayToBS(num)));
    }
  }
  }
}

ac Solution Code:
    public static TreeNode SortedArrayToBST(int[] input)
		{
			return ConvertHelper (input, 0, input.Length - 1);
		}

		public static TreeNode SortedArrayToBST(int[] input, int start, int end)
		{
			if (start > end) 
				return null;
			int mid = (start + end) / 2;
			TreeNode root = new TreeNode (input [mid]);
			root.Left = SortedArrayToBST (input, start, mid - 1);
			root.Right = SortedArrayToBST (input, mid + 1, end);
			return root;
		}
