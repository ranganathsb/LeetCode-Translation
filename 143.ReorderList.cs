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
    public void ReorderList(ListNode head) {
        
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
      new Solution().ReorderList(head);
      file.WriteLine(__Serializer__.serialize(head));
    }
  }
  }
}


ac Solution Code:
public class Solution {
    public void ReorderList(ListNode head) {
       if (head == null || head.next == null) //handle edge case
				return;
			//split the list use fast and slow pointers
			ListNode fast = head;
			ListNode slow = head;
			while (fast.next != null && fast.next.next != null) {
				fast = fast.next.next;
				slow = slow.next;
			}
			ListNode second = slow.next;
			slow.next = null; //final step for splitting list, cut two lists off

			//reverse second list
			second = ReverseList (second);

			ListNode first = head;
			while (first != null && second != null) {
				ListNode temp1 = first.next;
				ListNode temp2 = second.next;
				second.next = first.next;
				first.next = second;
				first = temp1;
				second = temp2;
			}
    }
    
    private static ListNode ReverseList(ListNode head){ //reverse the list 
			if (head == null || head.next == null) //handle edge case
				return head;

			ListNode current = head;
			ListNode next = head.next;
			while (next != null) {
				ListNode temp = next.next;
				next.next = current;
				current = next;
				next = temp;
			}
			head.next = null; //set original head.next to null
			return current;
		}
}

