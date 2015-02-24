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
      string[] input = line.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
      int[] num = input.Skip(1).Select(y => int.Parse(y))
                       .ToArray();
      file.WriteLine(__Serializer__.serialize(new Solution().FindMin(num)));
    }
  }
  }
}

ac Solution Code:
public class Solution {
    public int FindMin(int[] A) {
			int L = 0, R = A.Length - 1;
			while (L < R) {
				int M = (L + R) / 2;
				if (A[M] > A[R]) {
					L = M + 1;
				} else if (A[M] < A[L]) {
					R = M;
				} else if (A[L] == A[M] && A[M] == A[R]) {
					L = L + 1;
				} else {
					// A[L] = A[M] < A[R] or
					// A[L] < A[M] = A[R] or
					// A[L] < A[M] < A[R]
					R = L;
				}
			}
			return A[L];
    }
}
