namespace AdventOfCode.Core.Day8; 
 
internal static partial class Day8 { 
 
    internal static class Part2 {  
        
        private class UnionFind(int n) : UnionFindBase(n) {

            private readonly int _n = n;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="id1"></param>
            /// <param name="id2"></param>
            /// <returns>true if max circuit size limit is reached</returns>
            internal override bool Union(int id1, int id2) {
                int rootId1 = Find(id1);
                int rootId2 = Find(id2);
                if(rootId1 == rootId2) return false;

                if(_treeSizes[rootId1] < _treeSizes[rootId2]) {
                    _parents[rootId1] = rootId2;
                    _treeSizes[rootId2] += _treeSizes[rootId1];
                    _treeSizes[rootId1] = 0;
                    return _n == _treeSizes[rootId2];
                } 

                _parents[rootId2] = rootId1;
                _treeSizes[rootId1] += _treeSizes[rootId2];
                _treeSizes[rootId2] = 0;
                return _n == _treeSizes[rootId1];

            }

        }
 
        internal static long MergeAllInOneBigCircuit(string rawText) { 
 
            
            (int n, PriorityQueue<(Point p1, Point p2), double> priorityQueue) = HandleInput(rawText);

            UnionFind uf = new(n);
            
            while(priorityQueue.Count > 0) {

                var (p1, p2) = priorityQueue.Dequeue();

                bool lastUnion = uf.Union(p1.Id, p2.Id);

                if(lastUnion) return p1.X * p2.X;

            }

            throw new Exception("No solution found");


        } 
 
    } 
} 
