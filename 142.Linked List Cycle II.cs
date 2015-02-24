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
    public ListNode DetectCycle(ListNode head) {
        
    }
}

Driver Code:
Java:
class __Driver__ {
    public static void main(String[] args) throws IOException {
        PrintWriter printWriter = new PrintWriter(new FileWriter("user.out"), true);
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));

        String line;
        while ((line = in.readLine()) != null) {
            String[] input = line.split(", ");
            ListNode head = ListNode.deserialize(input[0]);
            int x = Integer.parseInt(input[1]);

            ListNode tail = head, now = head;
            if (x != -1) {
                for (int i = 0; i < x; i++) {
                    now = now.next;
                }
                tail = now;
                while (tail.next != null) {
                    tail = tail.next;
                }
                tail.next = now;
            }

            ListNode outputNode = new Solution().detectCycle(head);
            if (x != -1) {
                tail.next = null;
            }
            if (outputNode != null) {
                now = head;
                int outputIndex = -1;
                for (int i = 0; now != null; now = now.next, i++) {
                    if (outputNode == now) {
                        outputIndex = i;
                        break;
                    }
                }
                if (outputIndex > -1) {
                    printWriter.println("tail connects to node index " + outputIndex);
                } else {
                    printWriter.println("output node is not in the linked list");
                }
            } else {
                printWriter.println("no cycle");
            }
        }
    printWriter.close();
}
}

C#:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      string[] input = line.Split(new string[] { ", " }, StringSplitOptions.None);
      ListNode head = __ListNodeUtils__.deserialize(input[0]);
      int x = int.Parse(input[1]);
      ListNode now = head;
      ListNode tail = head;
      if(x!=-1){
          for(int i=0;i<x;i++){
              now=now.next;
          }
          tail = now;
          while(tail.next!=null){
              tail = tail.next;
          }
          tail.next = now;
      }
      
      ListNode outputNode = new Solution().DetectCycle(head);
      if(x!=-1){
          tail.next = null;
      }
      
      if(outputNode!=null){
          now = head;
          int outputIndex = -1;
          for(int i=0;now!=null;i++){
              if(outputNode == now){
                  outputIndex = i;
                  break;
              }
              now = now.next;
          }
          if(outputIndex>-1){
              file.WriteLine("tail connects to node index " + outputIndex);
          }
          else{
              file.WriteLine("output node is not in the linked list");
          }
      }
      else{
          file.WriteLine("no cycle");
      }
    }
  }
  }
}


ac Solution:
public class Solution {
    public ListNode DetectCycle(ListNode head) {
      ListNode slow = head;
			ListNode fast = head;
			while (slow != null && fast != null && fast.next != null) {
				slow = slow.next;
				fast = fast.next.next;
				if (slow == fast)  //if two pointers meet, there is a loop
					break;
			}
			
			if (fast == null || fast.next == null)
				return null;

			slow = head;
			while (slow != fast) {
				slow = slow.next;
				fast = fast.next;
			}
			return slow;
    }
}
