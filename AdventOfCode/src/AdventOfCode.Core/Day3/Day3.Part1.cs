namespace AdventOfCode.Core.Day3; 
 
internal static partial class Day3 { 
 
    internal static class Part1 { 

        private const int _minDigits = 2;

        private static int GetBankValue(string bank) {

            int n = bank.Length;
            if(n < _minDigits) throw new ArgumentException($"Bank must have at least {_minDigits} digits");

            int left = 0;
            int max = -1;

            for(int right = 1; right < n; right++) {
                int dec = (bank[left] - '0') *10;
                int u = bank[right] - '0';
                int curr = dec + u;
                if(curr > max)  max = curr;
                if( (bank[left] - '0') < (bank[right] - '0') ) left = right;
            }

            return max;
        }
 
        internal static long GetJoltage(string rawText) { 
 
            string[] banks = rawText.Split(Environment.NewLine);
            return banks.Sum(GetBankValue);
        } 
 
    } 
} 
