Code Definition:
/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
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

            if (x != -1) {
                ListNode now = head;
                for (int i = 0; i < x; i++) {
                    now = now.next;
                }
                ListNode tail = now;
                while (tail.next != null) {
                    tail = tail.next;
                }
                tail.next = now;
            }
            printWriter.println(__Serializer__.serialize(new Solution().hasCycle(head)));
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
      if(x!=-1){
          ListNode now = head;
          for(int i=0;i<x;i++){
              now=now.next;
          }
          ListNode tail = now;
          while(tail.next!=null){
              tail = tail.next;
          }
          tail.next = now;
      }
      file.WriteLine(__Serializer__.serialize(new Solution().HasCycle(head)));
    }
  }
  }
}

ac Solution Code:
public class Solution{
  public bool HasCycle(ListNode head){
    
			ListNode slow = head;
			ListNode fast = head;
			while (slow != null && fast != null && fast.next != null) {
				slow = slow.next;
				fast = fast.next.next;
				if (slow == fast)  //if two pointers meet, there is a loop
					return true;
			}
			return false;
  }
}
