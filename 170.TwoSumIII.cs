Code Definition:
public class TwoSum {

	public void Add(int number) {
	    
	}

	public bool Find(int value) {
	    
	}
}


Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
      TwoSum s = new TwoSum();
      int i=1;
      List<bool> ans = new List<bool>();
      while(i<input.Length){
          if(input[i]=="0")
            s.Add(int.Parse(input[i+1]));
          if(input[i]=="1")
            ans.Add(s.Find(int.Parse(input[i+1])));
          i+=2;
      }
      file.WriteLine(__Serializer__.serialize(ans));
    }
  }
  }
}


Ac Solution Code:
public class TwoSum {
    private Dictionary<int,int> dict = new Dictionary<int,int>();
	public void Add(int number) {
	    if(dict.ContainsKey(number))
	        dict[number]++;
	    else 
	        dict.Add(number, 1);
	}

	public bool Find(int value) {
	    foreach(KeyValuePair<int,int> kp in dict){
	        int i = kp.Key;
	        if(dict.ContainsKey(value-i)){
	            if(i==value-i&&dict[i]==1)
	                return false;
	            return true;
	        }
	    }
	    return false;
	}
}
