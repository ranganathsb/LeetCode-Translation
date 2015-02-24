Code Definition:
public class Solution {
    public int FindMin(int[] num) {
        
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
      file.WriteLine(__Serializer__.serialize(new Solution().FindMin(num)));
    }
  }
  }
}

ac Solution Code:
public class Solution {
    public int FindMin(int[] num) {
        if(num.Length == 0)
            return -1;
        int length = num.Length;
        int left =0;
        int right = length-1;
        while(left<right){
            int middle = (left+right)/2;
            if(num[right]<num[middle]) //minmum must be at the right sub
                left = middle+1;
            else         //minmum must be at the left sub
                right = middle;
        }
        return num[left];
    }
}

