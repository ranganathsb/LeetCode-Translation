Code Definition:
/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        
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
            foreach (UndirectedGraphNode neighbor in now.neighbors)
            {
                if (hashB.Add(neighbor)) {
                    que.Add(neighbor);
                }
            }
            head++;
        }
        return null;
    }

  static void Main(string[] args) {
  using (StreamWriter file = new StreamWriter("user.out")) {
    file.AutoFlush = true;
    string line;
    while ((line = Console.ReadLine()) != null) {
        UndirectedGraphNode node = __UndirectedGraphNodeUtils__.deserialize(line);
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

//DFS Recursive Solution
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        if(node==null) return null;
        Dictionary<UndirectedGraphNode,UndirectedGraphNode> dic = new Dictionary<UndirectedGraphNode,UndirectedGraphNode>();
        return DFS(node,dic);
    }
    
    private UndirectedGraphNode DFS(UndirectedGraphNode node, Dictionary<UndirectedGraphNode,UndirectedGraphNode> dic){
        if(dic.ContainsKey(node))
            return dic[node];
        UndirectedGraphNode copyNode = new UndirectedGraphNode(node.label);
        dic.Add(node,copyNode);
        foreach(UndirectedGraphNode neighbor in node.neighbors){
            copyNode.neighbors.Add(DFS(neighbor,dic));
        }
        return copyNode;
    }
}

	//BFS Iterative Solution
	public class Solution {
    		public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        		if (node == null)
				return null;
			Dictionary<UndirectedGraphNode, UndirectedGraphNode> dic = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();			
			Queue<UndirectedGraphNode> q = new Queue<UndirectedGraphNode>();
			UndirectedGraphNode newNode = new UndirectedGraphNode (node.label);
			q.Enqueue(node);
			dic.Add(node, newNode);
			while (q.Count != 0) {
				UndirectedGraphNode currNode = q.Dequeue();
				foreach (UndirectedGraphNode neighbor in currNode.neighbors) {
					if (!dic.ContainsKey (neighbor)) {
						q.Enqueue(neighbor);
						UndirectedGraphNode copyNeighbor = new UndirectedGraphNode (neighbor.label);
						dic[currNode].neighbors.Add(copyNeighbor);
						dic.Add(neighbor, copyNeighbor);
					} else
						dic[currNode].neighbors.Add (dic[neighbor]);
				}
			}
			return newNode;
    }
}
