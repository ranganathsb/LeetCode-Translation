Code Definition:


Driver Code:


ac Solution Code:
public class Solution {
    public int search(int[] A, int target) {
        int length = A.Length;
        int L = 0, R = length-1;
        while (L < R) {
            int M = (L+R)/2;
            if (A[L] <= A[M]) { //left sub is sorted
                if (A[L] <= target && target <= A[M]) { //in left sub
                    R = M;
                } else { //in right sub
                    L = M+1;
                }
            } else { //right sub is sorted
                if (A[M] <= target && target <= A[R]) { //in right sub
                    L = M;
                } else {  //in left sub
                    R = M-1;
                }
            }
        }
        if (A[L] == target) return L;
        return -1; //target is not in array
    }
}
