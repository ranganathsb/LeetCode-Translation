Code Definition:
public class Solution {
    public void ReverseWords(char[] s) {
        
    }
}


Driver Code:
class __Driver__ {
  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
      char[] s = line.Substring(1,line.Length-2).ToCharArray();
      new Solution().ReverseWords(s);
      file.WriteLine(__Serializer__.serialize(s));
    }
  }
  }
}


Ac Solution Code:
public class Solution {
    public void ReverseWords(char[] s) {
        int start=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]==' '){
                ReverseHelper(s, start, i-1);
                start = i+1;
            }
            if(i==s.Length-1)
                ReverseHelper(s, start, i);
        }
        ReverseHelper(s, 0, s.Length-1);
    }
    
    private void ReverseHelper(char[] s, int start, int end){
        while(start < end){
            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;
            start++;
            end--;
        }
    }
}
