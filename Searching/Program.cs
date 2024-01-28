namespace Searching
{
    internal class Searching
    {
        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for(int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }
            SearchNode(graph, start, visited, parents);
 
        }

        private static void SearchNode(bool[,] graph, int start, bool[] visited, int[] parents)
        {
            visited[start] = true;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] &&
                      !visited[i])
                {
                    parents[i] = start;
                    SearchNode(graph, i, visited, parents);
                }
            }
        }

        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for( int i =0; i< graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;

            }
            visited[start] = true;

            Queue<int> bfsQueue = new Queue<int>();

            bfsQueue.Enqueue(start);
            while (bfsQueue.Count > 0) 
            {
              int next = bfsQueue.Dequeue();

                for(int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[next, i] &&
                        !visited[i])
                    {
                        visited[i] = true;
                        parents[i] = next;
                        bfsQueue.Enqueue(i);
                    }

                }
            }
        }
    }   
  
    internal class Program
    {

        static void Main(string[] args)
        {
           /* bool[,] graph = new bool[8, 8]
            {
                { false,  true, false, false, false, false, false, false },
                {  true, false,  true, false, false,  true, false, false },
                { false,  true, false, false,  true,  true, false, false },
                { false, false, false, false, false,  true, false, false },
                { false, false,  true, false, false, false,  true,  true },
                { false,  true,  true,  true, false, false, false, false },
                { false, false, false, false,  true, false, false, false },
                { false, false, false, false,  true, false, false, false },
            };*/ 
            bool[,] graph = new bool[8, 8]
            {
                { false, false, false, true, true, false, false, false },
                { false, false,  false, true, false,  true, true, false },
                { false,  false, false, false,  false,  false, true, false },
                { true,true, false, false, false,  true, false, true },
                { true, false,  false, false, false, false,  true,  false },
                { false,  true,  false,  true, false, false, true, true },
                { false, false, true, false,  true, true, false, true },
                { false, false, false, true,  false, true,true, false },
            };

            // DFS 탐색
            bool[] dfsVisited;
            int[] dfsPath;
            Searching.DFS(graph, 0, out dfsVisited, out dfsPath);
            Console.WriteLine("<DFS>");
            PrintGraphSearch(dfsVisited, dfsPath);
            Console.WriteLine();

            // BFS 탐색
            bool[] bfsVisited;
            int[] bfsPath;
            Searching.BFS(graph, 0, out bfsVisited, out bfsPath);
            Console.WriteLine("<BFS>");
            PrintGraphSearch(bfsVisited, bfsPath);
            Console.WriteLine();
        }

        private static void PrintGraphSearch(bool[] visited, int[] path)
        {
            Console.WriteLine($"{"Vertex",8}{"Visit",8}{"Path",8}");

            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,8}{visited[i],8}{path[i],8}");
            }
        }



    }
    
}
