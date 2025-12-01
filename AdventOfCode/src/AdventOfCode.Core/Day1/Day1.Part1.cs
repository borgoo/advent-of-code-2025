namespace AdventOfCode.Core.Day1; 
 
internal static partial class Day1 {

    internal const int _startingVal = 50;
    internal const int _endVal = 0;
    internal const int _mod = 100;
    internal static readonly Dictionary<char, int> _map = new(){
            { 'L', -1 },
            { 'R', +1 }
        };

    internal readonly record struct Input(char C, int Value)
    {

        internal readonly int Mul { get; init; } = _map[C] * Value;
        internal readonly bool PositiveOrNull { get; init; } = _map[C] >= 0;
    }


    internal static class Part1 {

      
        internal static int FindPassword(string rawText)
        {
            int pswd = 0;
            int curr = _startingVal;
            IEnumerable<Input> inputs = rawText.Split(Environment.NewLine).Select(l => new Input(l[0], int.Parse(l[1..])));

            foreach (Input input in inputs) {

                curr = (curr + input.Mul) % _mod;
                if (curr < 0) curr += _mod;

                if (curr == _endVal) pswd++;
                
            }

            return pswd;


        } 
 
    } 
} 
