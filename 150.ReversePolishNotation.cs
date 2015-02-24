Code Definition:
public class Solution {
    public int EvalRPN(string[] tokens) {
        
    }
}

Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      string[] strs = line.Split().Skip(1).ToArray();
      file.WriteLine(__Serializer__.serialize(new Solution().EvalRPN(strs)));
    }
  }
  }
}

ac Solution Code:
public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int> ();
		foreach (string s in tokens) {
			if (s [0] == '-' && s.Length > 1 || (s [0] >= '0' && s [0] <= '9'))
				stack.Push (Convert.ToInt32 (s));
			else {
				int num1 = stack.Pop ();
				int num2 = stack.Pop ();
				if (s == "+")
					stack.Push (num2 + num1);
				else if (s == "-")
					stack.Push (num2-num1);
				else if (s == "*")
					stack.Push (num2 * num1);
				else if (s == "/")
					stack.Push (num2 / num1); 
				}
		}
		return stack.Pop ();
    }
}

