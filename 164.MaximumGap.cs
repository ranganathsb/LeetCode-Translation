Code Definition:
public class Solution {
    public int MaximumGap(int[] num) {
        
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
      file.WriteLine(__Serializer__.serialize(new Solution().MaximumGap(num)));
    }
  }
  }
}

ac Solution Code:
public class Solution{
		public int MaximumGap(int[] num){
			if (num.Length < 2) 
				return 0;

			int min = num[0]; 
			int max = num[0];
			foreach (int i in num) {
				if (i > max)
					max = i;
				if (i < min)
					min = i;
			}

			int bucketLen = (int)Math.Ceiling ((double)(max - min) /(double)(num.Length - 1)); //get bucket length
			int bucketNum = (max - min) / bucketLen + 1; 

			List<int[]> buckets = new List<int[]> (bucketNum); 
			for (int i = 0; i < bucketNum; i++) {
				buckets.Add (new int[2]{-1,-1}); 
			}

			foreach (int k in num) {  
				int i = (k - min) / bucketLen;
				if (buckets [i] [0] == -1 && buckets [i] [1] == -1) { 
					buckets [i] [0] = k; 
					buckets [i] [1] = k; 
				} else {
					if (k < buckets [i] [0])
						buckets [i] [0] = k;
					if (k > buckets [i] [1])
						buckets [i] [1] = k;
				}

			}
			int gap = 0;
			int prev = 0; 
			for (int i = 1; i < bucketNum; i++) { 
				if (buckets [i] [0] != -1) {
					int currGap = buckets[i][0] - buckets[prev][1];
					if (currGap > gap)
						gap = currGap;
					prev = i;
				}
			}
			return gap;
		}
	}
