namespace AdventOfCode.Core.Day5; 
 
internal static partial class Day5 { 
 
    internal static class Part2 { 

        internal static long CountHowManyFreshIngredientsThereAre(string rawText) { 
 
            string[] data = rawText.Split(Environment.NewLine + Environment.NewLine); 

            PriorityQueue<(long from, long to), long> heap = new();

            IEnumerable<(long from, long to)> ranges = data[0].Split(Environment.NewLine).Select(s => s.Split('-')).Select(s => (long.Parse(s[0]), long.Parse(s[1])));
            foreach(var range in ranges) {
                heap.Enqueue(range, range.from);
            }

            long result = 0;
            while(heap.Count > 0) {
                var curr = heap.Dequeue();
                if(heap.Count == 0) {
                    result += curr.to - curr.from + 1;
                    break;
                }
                
                var next = heap.Peek();
                if(next.from > curr.to) {
                    result += curr.to - curr.from + 1;
                    continue;
                }

                heap.Dequeue(); // next is merged, burn it
                var merge = (curr.from, Math.Max(curr.to,next.to));

                heap.Enqueue(merge, merge.from);

            }

            return result;


        } 
 
    } 
} 
