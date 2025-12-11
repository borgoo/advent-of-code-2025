using Microsoft.Z3;

namespace AdventOfCode.Core.Day10; 
 
internal static partial class Day10 { 
 
    internal static class Part2 {

        /// <summary>
        /// My approach:
        /// - For each position in expected find the button that affects it
        /// - write an eq with Bi = number of times button i is pressed
        ///  eg. B1 + B3 = 5 -> B1 and B2 both affect position 5
        /// - use Z3 to solve the system of equations
        /// - minimize the total number of presses
        /// - return the total number of presses
        /// </summary>
        /// <param name="expected">expected[pos]=target value at position pos</param>
        /// <param name="buttons">buttons[buttonId]=list of affected positions by buttonId</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static long SolveWithZ3(int[] expected, int[][] buttons) {

            const string buttonPrefix = "BUTTON_";
            int numberOfButtons = buttons.Length;

            using var ctx = new Context();
            using Optimize opt = ctx.MkOptimize();
            IntExpr[] variables = new IntExpr[numberOfButtons];

            // each BUTTON_i pressed >= 0
            for (int i = 0; i < numberOfButtons; i++)
            {
                variables[i] = ctx.MkIntConst($"{buttonPrefix}{i}");
                opt.Add(ctx.MkGe(variables[i], ctx.MkInt(0)));
            }

            for(int pos = 0; pos < expected.Length; pos++){
                int target = expected[pos];
                
                List<ArithExpr> parameters = [];
                for(int buttonId = 0; buttonId < numberOfButtons; buttonId++){
                    if(!buttons[buttonId].Contains(pos)) continue;
                    parameters.Add(variables[buttonId]);
                }
                if(parameters.Count == 0) continue;
                ArithExpr eq = ctx.MkAdd(parameters);
                opt.Add(ctx.MkEq(eq, ctx.MkInt(target))); // target = BUTTON_0 + BUTTON_3 + ...
            }

            opt.MkMinimize(ctx.MkAdd(variables)); // minimize the total number of presses

            if(opt.Check() != Status.SATISFIABLE) throw new Exception("Not solvable.");
            var model = opt.Model;
            long result = 0;
            for(int i = 0; i < numberOfButtons; i++){
                result += ((IntNum)model.Eval(variables[i])).Int;
            }
            return result;
        }
 
        internal static long ConfigureJoltageLevels(string rawText) { 

            string[] lines = rawText.Split(Environment.NewLine);
            
            List<(int[] expected, int[][] buttons)> inputs = [];
            foreach(string line in lines) {

                string[] parts = line.Split(' ');

                int[] expected = [.. parts[^1][1..^1].Split(",").Select(int.Parse)];             
                
                int[][] buttons = [.. parts[1..^1].Select(l => l[1..^1].Split(",").Select(int.Parse).ToArray() )];              

                inputs.Add((expected, buttons));
            }

            long result = 0;
            Parallel.ForEach(inputs,  input => 
                Interlocked.Add(ref result, SolveWithZ3(input.expected, input.buttons)
            ));

            return result;
        }
    }
} 
