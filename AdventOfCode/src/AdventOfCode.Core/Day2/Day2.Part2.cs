namespace AdventOfCode.Core.Day2; 
 
internal static partial class Day2 { 


    internal class Part2 : Part1 { 

        private readonly Dictionary<int, List<(int rangeLength, List<int> ptrsPositions)>> _cache = [];  // length of origin number -> possible pointers configurations

        private List<(int, List<int>)> GetPtrsFromCache(string str){

            int key = str.Length;
            if(_cache.ContainsKey(key)) return _cache[key];

            int m = str.Length/2;


            _cache[key] = [];
            for(int l = m; l > 0; l--) {
                if(str.Length % l != 0) continue;
                List<int> ptrs = [];
                for (int j = 0; j < str.Length / l; j++) ptrs.Add(j*l);

                _cache[key].Add((l, ptrs));            

            }

            return _cache[key];

        }

        protected override bool IsValid(long value) {
            string str = value.ToString();
            List<(int, List<int>)> ptrsList = GetPtrsFromCache(str);

            bool atLeastOneWithRepeatedDigitsOnly = 
                ptrsList.Any(data => {

                    int l = data.Item1;
                    List<int> ptrs = data.Item2;

                    for(int relativePos = 0; relativePos < l; relativePos++) {
                        char curr = str[ptrs[0] + relativePos];
                        for(int otherPtr = 1; otherPtr < ptrs.Count; otherPtr++) {
                            char otherCurr = str[ptrs[otherPtr] + relativePos];
                            if(curr != otherCurr) return false;
                        }
                    }
                    
                    return true;
                });            

            return !atLeastOneWithRepeatedDigitsOnly;
            
        }
    } 
} 
