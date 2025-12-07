namespace AdventOfCode.Core.Day6; 
 
internal static partial class Day6 { 
 
    internal static class Part2 { 

        private static readonly Dictionary<char, Func<IList<long>, long>> _operations = new(){
            { '+', a => a.Sum() },
            { '*', a => a.Aggregate(1L, (acc, x) => acc * x) }
        };
 
        internal static long DoVerticalMath(string rawText) { 
 
            char[][] grid = [.. rawText.Split(Environment.NewLine).Select(line => line.ToCharArray())];
            int n = grid.Length;
            int m = grid[0].Length; 
            long result = 0;
            List<long> list = [0];

            for(int j = m-1; j >= 0; j--) {

                bool emptyColumn = true;
                for(int i = 0; i < n; i++) {
                    char c = grid[i][j];

                    if(_operations.ContainsKey(c)) {

                        result += _operations[c](list);
                        list.Clear();
                        break;

                    }
                    if(!char.IsDigit(c)) continue;

                    emptyColumn = false;
                    list[^1] = list[^1]*10 + (c - '0');

                }
                if(!emptyColumn) list.Add(0);
            }

            return result;
        } 
 
    } 
} 
