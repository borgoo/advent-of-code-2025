namespace AdventOfCode.Core.Day6; 
 
internal static partial class Day6 { 
 
    internal static class Part1 { 

        private static readonly Dictionary<string, Func<long, long, long>> _operations = new(){
            { "+", (a, b) => a + b },
            { "*", (a, b) => a * b }
        };
 
        internal static long DoMath(string rawText) { 
 
            string[][] grid = [.. rawText.Split(Environment.NewLine).Select(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries))];
            int n = grid.Length;
            int m = grid[0].Length;

            long result = 0;
            for(int j = 0; j < m; j++){
                string op = grid[n-1][j];
                long partial = long.Parse(grid[0][j]);
                for(int i = 1; i < n-1; i++) {
                    partial = _operations[op](partial, long.Parse(grid[i][j]));
                }
                result += partial;
            }

            return result;

        } 
 
    } 
} 
