namespace AdventOfCode.Core.Day1; 
 
internal static partial class Day1 {


    internal static class Part2 { 

 
        internal static int FindPasswordWith0x434C49434BMethod(string rawText) {

            int pswd = 0;
            int curr = _startingVal;
            IEnumerable<Input> inputs = rawText.Split(Environment.NewLine).Select(l => new Input(l[0], int.Parse(l[1..])));

            foreach (Input input in inputs)
            {

                if(input.PositiveOrNull) {
                    pswd += (curr + input.Mul) / _mod;
                    curr = (curr + input.Mul) % _mod;
                    continue;
                }

                int position = curr == 0 ? curr : _mod - curr;
                position += input.Value;
                pswd += position / _mod;
                int remainig = position % _mod;
                curr = remainig == 0 ? remainig : _mod - remainig;            

            

            }

            return pswd;

        } 
 
    } 
} 
