Code Definition:
/**
 * Definition for undirected graph.
 * class UndirectedGraphNode {
 *     int label;
 *     List<UndirectedGraphNode> neighbors;
 *     UndirectedGraphNode(int x) { label = x; neighbors = new ArrayList<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode cloneGraph(UndirectedGraphNode node) {
        
    }
}

Driver Code:

class __Driver__ {
    private static UndirectedGraphNode IsCopied(UndirectedGraphNode A, UndirectedGraphNode B) {
        if (A == null || B == null) return null;
        
        HashSet<UndirectedGraphNode> hash = new HashSet<UndirectedGraphNode>();
        List<UndirectedGraphNode> que = new List<UndirectedGraphNode>();
        int head = 0;
        hash.Add(A);
        que.Add(A);
        while (head < que.Count) {
            UndirectedGraphNode now = que[head];
            foreach (UndirectedGraphNode neighbor in now.neighbors)
            {
                if (hash.Add(neighbor)) {
                    que.Add(neighbor);
                }
            }
            head++;
        }
        
        HashSet<UndirectedGraphNode> hashB = new HashSet<UndirectedGraphNode>();
        que.Clear();
        head = 0;
        hashB.Add(B);
        que.Add(B);
        while (head < que.Count) {
            UndirectedGraphNode now = que[head];
            if (hash.Contains(now)) return now;
            for (UndirectedGraphNode neighbor : now.neighbors)
            {
                if (hashB.Add(neighbor)) {
                    que.Add(neighbor);
                }
            }
            head++
        }
        return null;
    }

  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
        UndirectedGraphNode node = UndirectedGraphNode.deserialize(s);
        UndirectedGraphNode copied = new Solution().CloneGraph(node);
        UndirectedGraphNode same = IsCopied(node, copied);
            if (same == null) {
                file.WriteLine(__Serializer__.serialize(copied));
            } else {
                file.WriteLine("Node with label " + same.label + " was not copied but a reference to the original one.");
            }
    }
  }
  }
}


ac Solution Code:
