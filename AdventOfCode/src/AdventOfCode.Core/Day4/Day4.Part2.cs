namespace AdventOfCode.Core.Day4; 
 
internal static partial class Day4 { 
 
    internal static class Part2 { 
 
        internal static long GetHowManyRollsOfPaperCanBeRemoved(string rawText) { 
 
            char[][] grid = [.. rawText.Split(Environment.NewLine).Select(line => line.ToCharArray())];
            int n = grid.Length;
            int m = grid[0].Length;
            HashSet<(int, int)> rolls = [];
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < m; j++) {
                    if(grid[i][j] == _rollOfPaper) rolls.Add((i, j));
                }
            }

            int result = 0;
            int removed;
            do {

                removed = 0;
                foreach(var (i, j) in rolls.ToArray()) {

                    int adjacentRollsOfPaper = 0;
                    foreach(var (dx,dy) in _directions) {
                        int x = i + dx;
                        if(x < 0 || x >= n) continue;
                        int y = j + dy;
                        if(y < 0 || y >= m) continue;
                        if(grid[x][y] == _rollOfPaper) {
                            adjacentRollsOfPaper++;
                            if(adjacentRollsOfPaper == _maxAdjacentRolls) break;                            
                        }
                    }

                    if(adjacentRollsOfPaper < _maxAdjacentRolls) {
                        removed++;
                        rolls.Remove((i, j));
                        grid[i][j] = _emptySpace;
                    }
                }
                
                result += removed;

            } while(removed > 0);

            return result;
        } 
 
    } 
} 
