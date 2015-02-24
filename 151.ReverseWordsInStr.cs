Code Definition:
public class Solution {
    public string ReverseWords(string s) {
        
    }
}

Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      string str = line.Substring(1,line.Length-2)
      file.WriteLine(__Serializer__.serialize(new Solution().ReverseWords(str)));
    }
  }
  }
}

ac Solution Code:
public class Solution {
    public string ReverseWords(string s) {
            StringBuilder sb = new StringBuilder ();
			int j = s.Length; 
			for (int i = s.Length - 1; i >= 0; i--) {
				if (s[i] == ' ')  
					j = i;
				else if(i==0 || s[i-1]==' '){  
					if (sb.Length != 0)  
						sb.Append (' ');
					sb.Append (s.Substring (i, j - i));
				}
			}
			return sb.ToString ();
    }
}

