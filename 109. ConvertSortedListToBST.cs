Code Definition:
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; next = null; }
 * }
 */
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
    public TreeNode SortedListToBST(ListNode head) {
        
    }
}

Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      ListNode head = __ListNodeUtils__.deserialize(line);
      file.WriteLine(__Serializer__.serialize(new Solution().SortedListToBST(head)));
    }
  }
  }
}

ac Solution Code: O(n)
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; next = null; }
 * }
 */
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
    TreeNode SortedListToBST(ref ListNode head, int start, int end) {
      if (start > end) return null;
      int mid = start + (end - start) / 2;
      TreeNode leftChild = SortedListToBST(ref head, start, mid-1);
      TreeNode parent = new TreeNode(head.val);
      parent.left = leftChild;
      head = head.next;
      parent.right = SortedListToBST(ref head, mid+1, end);
      return parent;
    }
    
    public TreeNode SortedListToBST(ListNode head) {
      int n = 0;
      ListNode p = head;
      while (p != null) {
          p = p.next;
          n++;
      }
      return SortedListToBST(ref head, 0, n-1);
    }
}

tle Solution: O(nlogn)
public class Solution {
    // O(N log N) solution, TLE.
    // No need to use global var or pass by ref
    int getVal(ListNode head, int idx) {
        int i = 0;
        ListNode p = head;
        while (p != null) {
            if (i == idx) return p.val;
            p = p.next;
            i++;
        }
        return -1;
    }
    TreeNode SortedListToBST(ListNode head,int start, int end) {
      if (start > end) return null;
      // same as (start+end)/2, avoids overflow.
      int mid = start + (end - start + 1) / 2;
      TreeNode node = new TreeNode(getVal(head, mid));
      node.left = SortedListToBST(head,start, mid-1);
      node.right = SortedListToBST(head,mid+1, end);
      return node;
    }
    
    public TreeNode SortedListToBST(ListNode head) {
      int n = 0;
      ListNode p = head;
      while (p != null) {
          p = p.next;
          n++;
      }
      return SortedListToBST(head,0, n-1);
    }
}
