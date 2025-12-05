using System.Buffers;
using System.Collections;

namespace AdventOfCode.Core.Day5; 
 
internal static partial class Day5 { 
 
    internal static class Part1 { 
 
        internal static long CountFreshIngredients(string rawText) { 

            string[] data = rawText.Split(Environment.NewLine + Environment.NewLine); 

            (long from, long to)[] ranges = [.. data[0].Split(Environment.NewLine).Select(s => s.Split('-')).Select(s => (long.Parse(s[0]), long.Parse(s[1])))];
            Array.Sort(ranges, (a, b) => a.from.CompareTo(b.from));


            long result = 0;
            IEnumerable<long> ingredients = data[1].Split(Environment.NewLine).Select(long.Parse);
            foreach(long ingredient in ingredients ) {
                
                int i = 0;
                while(i < ranges.Length && ranges[i].to < ingredient) i++;

                while(i < ranges.Length && ranges[i].from <= ingredient) {

                    if(ingredient >= ranges[i].from && ingredient <= ranges[i].to) {
                        result++;
                        break;
                    }
                    i++;

                }
            }


            return result;

          
            
        } 
 
    } 
} 
