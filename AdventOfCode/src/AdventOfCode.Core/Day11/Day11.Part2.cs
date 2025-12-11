using System.Text;

namespace AdventOfCode.Core.Day11; 
 
internal static partial class Day11 { 
 
    internal static class Part2 { 

        private const string _startNode = "svr";
        private const string _endNode = "out";
        private const string _fftNode = "fft";
        private const string _dacNode = "dac";

        private static Dictionary<string, HashSet<string>> CutGraph(Dictionary<string, HashSet<string>> graph, HashSet<string> toCut) {
            Dictionary<string, HashSet<string>> tmpGraph = [];
            foreach( (string key, HashSet<string> nodes) in graph ) {
                if(toCut.Contains(key)) continue;
                tmpGraph[key] = [.. nodes.Except(toCut)];
            }
            return tmpGraph;
        }


 
        internal static long TailorMade(string rawText) { 
 
            Dictionary<string, HashSet<string>> graph = BuildGraph(rawText);

            // ToGraphViz(graph);

            Dictionary<string, HashSet<string>> tmpGraph = CutGraph(graph, ["vmx", "cdh", "orm", "njg"]);            
            long pathsFromStartToFft = DFS(tmpGraph, _startNode, _fftNode);

            tmpGraph = CutGraph(graph, ["khl", "you", "zaq"]); 
            long pathsFromFftToDac = DFS(tmpGraph, _fftNode, _dacNode);

            long pathsFromDacToEnd = DFS(graph, _dacNode, _endNode);


            return pathsFromStartToFft * pathsFromFftToDac * pathsFromDacToEnd;



        } 

        private static void ToGraphViz(Dictionary<string, string[]> graph) {

            StringBuilder sb = new();
            sb.AppendLine("digraph G {");
            sb.AppendLine($"{_startNode} [style=filled, fillcolor=red];");
            sb.AppendLine($"{_endNode} [style=filled, fillcolor=green];");
            sb.AppendLine($"{_fftNode} [style=filled, fillcolor=yellow];");
            sb.AppendLine($"{_dacNode} [style=filled, fillcolor=blue];");
            foreach( KeyValuePair<string, string[]> kvp in graph ) {
                sb.AppendLine(kvp.Key + " -> {" + string.Join(" ", kvp.Value) + "};");
            }
            sb.AppendLine("}");
            Console.WriteLine(sb.ToString());
        }
    }
}
