using System.Data;

namespace AdventOfCode.Core.Day2; 
 
internal static partial class Day2 { 

 
    internal class Part1 { 

        const char _rangeSeparator = ',';
        const char _rangeLimitsSeparator = '-';
        private readonly record struct Range(long From, long To);

        protected virtual bool IsValid(long value) {
            string str = value.ToString();
            if(str.Length % 2 != 0 || str.Length < 2) return true;
            long mul = (int)Math.Pow(10, str.Length/2);
            long left = value / mul;
            long right = value - (left*mul);
            return left != right;
            
        }
 
        internal long SumAllInvalidIDs(string rawText) { 
 
            IEnumerable<Range> ranges = rawText.Split(_rangeSeparator)
                                .Select(r => r.Split(_rangeLimitsSeparator))
                                .Select(r => new Range(long.Parse(r[0]), long.Parse(r[1])))
                                .OrderBy(r => r.From);

            Queue<long> invalidValues = [];
            long result = 0;
            foreach (var range in ranges)
            {
              
                while(invalidValues.Count > 0 && invalidValues.Peek() < range.From) invalidValues.Dequeue();

                for(long curr = range.From; curr <= range.To; curr++) {

                    if(IsValid(curr)) continue;
                    invalidValues.Enqueue(curr);
                    result += curr;

                }
            }

            return result;
        } 
 
    } 
} 
