namespace AdventOfCode.Core.Day9; 
 
internal static partial class Day9 { 
 
    internal static class Part1 {  
        internal static long FindLargestArea(string rawText) { 
 
            // X,Y inverted
            (long x, long y)[] redTiles = [.. rawText
                .Split(Environment.NewLine)
                .Select(l => l.Split(','))
                .Select(parts => (x: long.Parse(parts[1]), y: long.Parse(parts[0])))];
            
            int n = redTiles.Length;

            long maxArea = 0;
            for(int i = 0; i < n -1; i++)
                for(int j = i + 1; j < n; j++) 
                    maxArea = Math.Max(maxArea, Math.Abs(redTiles[i].x - redTiles[j].x +1) * Math.Abs(redTiles[i].y - redTiles[j].y +1));               
            
            return maxArea;
            
        } 
 
    }
} 
