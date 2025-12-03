namespace AdventOfCode.Core.Day3; 
 
internal static partial class Day3 { 
 
    internal static class Part2 { 

        private const int _minDigits = 12;
        private const short _null = 0;

        private static long GetBankValue(string bank) {

            int n = bank.Length;
            if(n < _minDigits) throw new ArgumentException($"Bank must have at least {_minDigits} digits");

            short[] max = new short[_minDigits];
            Array.Fill(max, _null);

            for(int right = 0; right < n; right++) {

                short curr = (short)(bank[right] - '0');

                int remaining = n - right;
                int startingPos = Math.Max(0, _minDigits - remaining);
                for(int pos = startingPos; pos < _minDigits; pos++) {

                    if(max[pos] < curr) {

                        max[pos] = curr;
                        Array.Fill(max, _null, pos+1, _minDigits-pos-1);                 

                        break;
                    }

                }
               
            }

            long result = 0;
            for(int i = 0; i < _minDigits; i++) {
                result = result * 10 + max[i];
            }

            return result;
        }
 
        internal static long GetJoltage(string rawText) { 
 
            string[] banks = rawText.Split(Environment.NewLine);
            return banks.Sum(GetBankValue);
        } 
 
    } 
} 
