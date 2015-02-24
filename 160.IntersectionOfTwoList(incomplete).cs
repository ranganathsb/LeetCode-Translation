Code Definition:
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        
    }
}

Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      string[] input = line.Split(new string[] { ", " }, StringSplitOptions.None);
      ListNode root1 = __ListNodeUtils__.deserialize(input[1]);
      ListNode root2 = __ListNodeUtils__.deserialize(input[2]);
      file.WriteLine(__Serializer__.serialize(new Solution().GetIntersectionNode(root1, root2)));
    }
  }
  }
}

ac Solution Code:
public class Solution{
  public ListNode GetIntersectionNode(ListNode headA, ListNode headB){
      int l1 = getLength (headA);
			int l2 = getLength (headB);
			if (l1 > l2) {
				int d = l1 - l2;
				return getIntersectionHelper (d, headA, headB);
			} else {
				int d = l2 - l1;
				return getIntersectionHelper (d, headB, headA);
			}
  }
  
  	//get length of a LinkedList
		private int getLength(ListNode head)
		{
			int l = 0;
			while (head!= null) {
				l++;
				head = head.next;
			}
			return l;
		}
		
		//get intersection using two Linkedlist and the length difference
		private ListNode getIntersectionHelper(int d, ListNode head1, ListNode head2)
		{
			for (int i = 0; i < d; i++) {
				if (head1 == null)
					return null;
				head1 = head1.next;
			}

			while (head1 != null && head2 != null) {
				if (head1 == head2)
					return head1;
				head1 = head1.next;
				head2 = head2.next;
			}
			return null;
		}
}


	

		
