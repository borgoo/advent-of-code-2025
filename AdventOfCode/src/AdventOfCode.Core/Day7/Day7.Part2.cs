namespace AdventOfCode.Core.Day7; 
 
internal static partial class Day7 { 
 
    internal static class Part2 { 

        // NO SPLITTERS ON LAST LINE
        private static long DFS(string[] lines, int n, int m, (int x, int y) current, Dictionary<(int x, int y), long> cache) {

            if(cache.ContainsKey(current)) return cache[current];

            (int x, int y) next = (current.x + _tachyonDirection.dx, current.y + _tachyonDirection.dy);

            while(next.x < n && lines[next.x][next.y] == _empty) next = (next.x + _tachyonDirection.dx, next.y + _tachyonDirection.dy);            

            if(next.x == n) return 1;

            long foundTimelines = 0;
            foreach((int dx, int dy) in _splitResults) {
                (int x, int y) splittedTachyon = (next.x + dx, next.y + dy);
                if(splittedTachyon.y < 0 || splittedTachyon.y >= m) continue;
                
                foundTimelines += DFS(lines, n, m, splittedTachyon, cache);
            }

            cache[current] = foundTimelines;
            return foundTimelines;           


        }
 
        internal static long CountDifferentTimelines(string rawText) { 
 
            string[] lines = rawText.Split(Environment.NewLine);
            int n = lines.Length;
            int m = lines[0].Length;
            (int x, int y) start = (0, lines[0].IndexOf(_start));
            Dictionary<(int x, int y), long> cache = [];

            return DFS(lines, n, m, start, cache);

        } 
 
    } 
} 
