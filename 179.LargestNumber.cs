Code Definition:
public class Solution{
    public string LargestNumber(int[] num){
        
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
      file.WriteLine(__Serializer__.serialize(new Solution().LargestNumber(num)));
    }
  }
  }
}

ac Solution Code:
public class Solution{
  public string LargestNumber(int[] num){
    StringBuilder sb = new StringBuilder ();
			List<string> strList = new List<string> (); 
			foreach (int i in num)
				strList.Add (i.ToString());
			strList.Sort (delegate(string x, string y) { 
				if(Convert.ToInt64(x+y)>Convert.ToInt64(y+x))
					return 1;
				if(Convert.ToInt64(x+y)<Convert.ToInt64(y+x))
					return -1;
				return 0;
			});
			bool IsLeadingZero = true; 
			for (int i = strList.Count - 1; i >= 0; i--) {
				if (IsLeadingZero && strList [i] == "0") 
					continue;
				IsLeadingZero = false;
				sb.Append (strList [i]); 
			}
			if(sb.Length==0) 
				return "0";
			return sb.ToString ();
  }
}
