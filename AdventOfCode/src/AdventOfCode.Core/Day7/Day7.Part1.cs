namespace AdventOfCode.Core.Day7; 
 
internal static partial class Day7 { 

    private const char _start = 'S';
    private const char _empty = '.';
    private static readonly (int dx, int dy) _tachyonDirection = (1,0);
 
    private static readonly (int dx, int dy)[] _splitResults = [
        (0,1),
        (0,-1)
    ];

    internal static class Part1 { 

 
        internal static long CountBeamSplitting(string rawText) { 
 
            string[] lines = rawText.Split(Environment.NewLine);
            int n = lines.Length;
            int m = lines[0].Length;
            (int x, int y) start = (0, lines[0].IndexOf(_start));

            int count = 0;

            Queue<(int x, int y)> nodes = [];
            HashSet<(int x, int y)> seen = [];
            nodes.Enqueue(start);
            seen.Add(start);

            while(nodes.Count > 0) {
                int num = nodes.Count;
                for(int i = 0; i < num; i++) {

                    (int x, int y) current = nodes.Dequeue();
                    (int x, int y) next = (current.x + _tachyonDirection.dx, current.y + _tachyonDirection.dy);
                    if(next.x >= n) continue;
                    if(seen.Contains(next)) continue;
                    seen.Add(next);
                    if(lines[next.x][next.y] == _empty) {
                        nodes.Enqueue(next);
                        continue;
                    }
                    
                    // I'm on a splitter
                    count++;
                    foreach((int dx, int dy) in _splitResults) {
                        (int x, int y) splittedTachyon = (next.x + dx, next.y + dy);
                        if(splittedTachyon.y < 0 || splittedTachyon.y >= m) continue;
                        if(seen.Contains(splittedTachyon)) continue;
                        seen.Add(splittedTachyon);
                        nodes.Enqueue(splittedTachyon);
                    }


                }
            }

            return count;



        } 
 
    } 
} 
