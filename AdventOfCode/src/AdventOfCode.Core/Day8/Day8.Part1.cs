namespace AdventOfCode.Core.Day8; 
 
internal static partial class Day8 { 

    private readonly record struct Point {
        internal readonly int Id;
        internal readonly int X;
        internal readonly int Y;
        internal readonly int Z;

        internal Point(int id, int[] arr) {
            Id = id;
            X = arr[0];
            Y = arr[1];
            Z = arr[2];
        }

        /// <summary>
        /// Euclidean distance between two points
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        internal double DistanceFrom(Point other){
            return Math.Sqrt((long)(X - other.X) * (X - other.X) + (long)(Y - other.Y) * (Y - other.Y) + (long)(Z - other.Z) * (Z - other.Z));
        }
    }

    private static (int n, PriorityQueue<(Point p1, Point p2), double> priorityQueue) HandleInput(string rawText) {

        int id = 0;
        Point[] points = [.. rawText.Split(Environment.NewLine).Select(l => new Point(id++,[.. l.Split(',').Select(int.Parse)]))];
        int n = points.Length;

        PriorityQueue<(Point p1, Point p2), double> priorityQueue = new();

        for(int i = 0; i < n-1; i++){

            for(int j = i+1; j < n; j++) {
                double distance = points[i].DistanceFrom(points[j]);
                priorityQueue.Enqueue((points[i], points[j]), distance);
            }
        }

        return (n, priorityQueue);

    }

    private abstract class UnionFindBase {

            protected readonly int[] _parents;
            protected readonly int[] _treeSizes;
            internal UnionFindBase(int n) {
                _parents = [.. Enumerable.Range(0, n)];
                _treeSizes = new int[n];
                Array.Fill(_treeSizes, 1);
            }

            internal int Find(int id) {
                if(_parents[id] != id) _parents[id] = Find(_parents[id]); // compression
                return _parents[id];
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="id1"></param>
            /// <param name="id2"></param>
            /// <returns>true if a union effectively occurred</returns>
            internal virtual bool Union(int id1, int id2) {
                int rootId1 = Find(id1);
                int rootId2 = Find(id2);
                if(rootId1 == rootId2) return false;

                if(_treeSizes[rootId1] < _treeSizes[rootId2]) {
                    _parents[rootId1] = rootId2;
                    _treeSizes[rootId2] += _treeSizes[rootId1];
                    _treeSizes[rootId1] = 0;
                    return true;
                } 

                _parents[rootId2] = rootId1;
                _treeSizes[rootId1] += _treeSizes[rootId2];
                _treeSizes[rootId2] = 0;
                return true;

            }

    }
 
    internal static class Part1 { 

        const int _limit = 3;       

        private class UnionFind(int n) : UnionFindBase(n) {           

            internal IEnumerable<int> GetBiggestSets(int limit) {
                return _treeSizes.OrderByDescending(size => size).Take(limit);
            }

        }
 
        internal static long MulSizeOfBiggestCircuits(string rawText, int remainingWires) { 

            (int n, PriorityQueue<(Point p1, Point p2), double> priorityQueue) = HandleInput(rawText);            
          

            UnionFind uf = new(n);
            
            while(priorityQueue.Count > 0) {

                var (p1, p2) = priorityQueue.Dequeue();

                uf.Union(p1.Id, p2.Id);

                remainingWires--;
                if(remainingWires == 0) break;

            }

            return uf.GetBiggestSets(_limit).Aggregate(1L, (a,b) => a * b);


        } 
 
    } 
} 
