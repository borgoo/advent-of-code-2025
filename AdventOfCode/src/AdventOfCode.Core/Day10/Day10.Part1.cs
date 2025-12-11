namespace AdventOfCode.Core.Day10; 
 
internal static partial class Day10 { 
 
    internal static class Part1 { 
        const char _off = '.';
        const char _on = '#';

        /// <summary>
        /// MSB -> right eg: 0,1,3,5 -> 110101
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static long ToBitMask(string list, int n)
        {

            var values = list.Split(',').Select(int.Parse);
            long bitMask = 0;
            foreach (int value in values)
            {
                bitMask |= 1L << (n - value - 1);
            }

            return bitMask;
        }

        private static long BFS(long expected, long[] bitMasks) {

            long start = 0;
            if(start == expected) return 0;
            
            Queue<long> queue = new();
            HashSet<long> seen = [];
            queue.Enqueue(start);
            seen.Add(start);

            int steps = 0;
            while(queue.Count > 0) {
                int num = queue.Count;
                steps++;
                for(int i = 0; i < num; i++) {
                    long current = queue.Dequeue();

                    foreach(long bitMask in bitMasks) {
                        long next = current ^ bitMask;
                        if(next == expected) return steps;
                        if(seen.Contains(next)) continue;
                        queue.Enqueue(next);
                        seen.Add(next);
                    }
                }
            }

            return steps;
        }

       
 
        internal static long ConfigureIndicatorLights(string rawText) { 

            string[] lines = rawText.Split(Environment.NewLine);
            
            List<(long expected, long[] bitMasks)> input = [];
            foreach(string line in lines) {
                string[] parts = line.Split(' ');

                string binaryString = parts[0][1..^1].Replace(_off, '0').Replace(_on, '1');
                int n = binaryString.Length;
                long expected = Convert.ToInt64(binaryString, 2);

                long[] bitMask = [.. parts[1..^1].Select(l => ToBitMask(l[1..^1], n) )];              

                input.Add((expected, bitMask));               
            }

            long result = 0;
            foreach (var (expected, bitMasks) in input) { 
                result += BFS(expected, bitMasks);
            }

            return result;

            
 
            
        } 
 
    } 
} 
