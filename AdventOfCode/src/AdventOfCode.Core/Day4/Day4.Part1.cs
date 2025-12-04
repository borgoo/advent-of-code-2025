namespace AdventOfCode.Core.Day4; 
 
internal static partial class Day4 { 

    private const char _rollOfPaper = '@';
    private const char _emptySpace = '.';
    private static readonly (int dx, int dy)[] _directions = [
        (0,1),
        (0,-1),
        (1,0),
        (-1,0),
        (1,1),
        (1,-1),
        (-1,1),
        (-1,-1)
    ];

    private const int _maxAdjacentRolls = 4;
 
    internal static class Part1 { 
 
        internal static long GetNumOfAccessibleRollsOfPaper(string rawText) { 
 
            string[] lines = rawText.Split(Environment.NewLine);
            int n = lines.Length;
            int m = lines[0].Length; 
            int result = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < m; j++) {

                    char c = lines[i][j];
                    if(c != _rollOfPaper) continue;
                    int adjacentRollsOfPaper = 0;
                    foreach(var (dx,dy) in _directions) {
                        int x = i + dx;
                        if(x < 0 || x >= n) continue;
                        int y = j + dy;
                        if(y < 0 || y >= m) continue;
                        if(lines[x][y] == _rollOfPaper) {
                            adjacentRollsOfPaper++;
                            if(adjacentRollsOfPaper == _maxAdjacentRolls) break;                            
                        }
                    }
                    if(adjacentRollsOfPaper < _maxAdjacentRolls) result++;
                    
                }
            }
            return result;
        } 
 
    } 
} 
