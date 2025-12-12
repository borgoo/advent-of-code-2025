namespace AdventOfCode.Core.Day12; 
 
internal static partial class Day12 { 

    /// <summary>
    /// NOT SOLVED. TRIED WITH Knuth's Algorithm X from https://en.wikipedia.org/wiki/Knuth%27s_Algorithm_X
    /// BUT SOLVED LOOKING AT THE REDDIT SOLUTIONS AFTER QUITTING
    /// </summary>
 
    internal static class Part1 { 

        const char _busy = '#';

        private record Universe(int N, int M){
            internal int Area {get; init;} = N * M;
        }
        private record Constraint(Universe Universe, int[] Shapes);
        private record Shape(int Id, string ShapeAsString){
            internal int Area {get; init;} = ShapeAsString.Count(c => c == _busy);
        }

        internal static long CountNumOfRegions(string rawText, decimal magicFactor = 1.2m) { 

            string[] tmp = rawText.Split(Environment.NewLine+Environment.NewLine);

            IEnumerable<Constraint> regions = [.. tmp[^1].Split(Environment.NewLine).Select(l =>{
                string[] parts = l.Split(": ");
                var tmp = parts[0].Split("x");

                Universe universe =new(int.Parse(tmp[0]), int.Parse(tmp[1]));
                int[] shapes = [.. parts[1].Split(" ").Select(int.Parse)];
                return new Constraint(universe, shapes);
            }
            )];

            Shape[] shapesMaps = new Shape[tmp.Length - 1];
            for(int i = 0; i < tmp.Length - 1; i++){
                string[] parts = tmp[i].Split(":"+Environment.NewLine);
                shapesMaps[i] = new Shape(int.Parse(parts[0]), parts[1]);
            }

            // try pruning some regions
            regions = regions.Where(r => {
                int required = 0;
                for(int id = 0; id < r.Shapes.Length; id++){
                    required += shapesMaps[id].Area * r.Shapes[id];
                }
                return r.Universe.Area >= required*magicFactor;

            });

            return regions.Count();
            
            
        } 
 
    } 
} 
