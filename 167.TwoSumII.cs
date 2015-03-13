Code Definition:
class Solution {
    public Tuple<int, int> TwoSum(int[] numbers, int target) {
        
    }
}


Driver Code:
class __Driver__
{
  static void Main(string[] args)
  {
    using (StreamWriter file = new StreamWriter("user.out"))
    {
      file.AutoFlush = true;
      string line;
      int total = Int32.Parse(Console.ReadLine());
      for (int i = 0; i < total; i++)
      {
        int target = Int32.Parse(Console.ReadLine());
        int count = Int32.Parse(Console.ReadLine()); // no use
        int[] arr = Console.ReadLine().Split(' ').Select((s) => Int32.Parse(s)).ToArray();
        Tuple<int, int> ret = new Solution().TwoSum(arr, target);
        file.WriteLine(String.Format("{0}, {1}", __Serializer__.serialize(ret.Item1), __Serializer__.serialize(ret.Item2)));
      }
      while ((line = Console.ReadLine()) != null)
      {
        int x = int.Parse(line);
      }
    }
  }
}



Ac Solution Code#1:
class Solution {
    public Tuple<int, int> TwoSum(int[] numbers, int target) {
        int p1=0, p2=numbers.Length-1;
        while(p1<p2){ 
            int sum = numbers[p1]+numbers[p2];
            if(sum>target)
                p2--;
            else if(sum<target)
                p1++;
            else
                return new Tuple<int,int>(p1+1,p2+1); /
        }
        throw new ArgumentException("No Two Sum Solution!", "target");
    }
}


Ac Solution Code#2:
class Solution {
    public Tuple<int, int> TwoSum(int[] numbers, int target) {
        for(int i =0;i<numbers.Length;i++){
            int result = BinarySearch(numbers, target-numbers[i],i+1);
            if(result!=-1)
                return new Tuple<int,int>(i+1, result+1);
        }
        throw new ArgumentException("No Two Sum Solution!", "target");
    }

    private int BinarySearch(int[] numbers, int target, int start){
        int L = start, R=numbers.Length-1;
        while(L<=R){
            int M = (L+R)/2;
            if(numbers[M]>target)
                R=M-1;
            else if(numbers[M]<target)
                L=M+1;
            else
                return M;
        }
        return -1;
    }
}


TLE Solution Code:
class Solution {
    public Tuple<int, int> TwoSum(int[] numbers, int target) {
        int len = numbers.Length;
        for (int i = 0; i < len - 1; i ++) {
            int k = target - numbers[i];
            for (int j = i + 1; j < len; j ++) {
                if (numbers[j] == k) {
                    return new Tuple<int,int>(i + 1, j + 1);
                }
            }
        }
        return null;
    }
}
