namespace AdventOfCode.Core.Day11; 
 
internal static partial class Day11 {


    private static long DFS(Dictionary<string, HashSet<string>> graph, string currentNode, string endNode)
    {

        long count = 0;
        foreach (string neighbor in graph[currentNode])
        {
            if (neighbor == endNode) count++;
            else count += DFS(graph, neighbor, endNode);
        }
        return count;
    }

    private static Dictionary<string, HashSet<string>> BuildGraph(string rawText) {

        Dictionary<string, HashSet<string>> graph = [];

        foreach (string[] line in rawText.Split(Environment.NewLine).Select(line => line.Split(": ")))
        {
            string key = line[0];
            HashSet<string> nodes = [..line[1].Split(" ")];
            graph[key] = nodes;
        }

        return graph;

    }

    internal static class Part1 { 

        private const string _startNode = "you";
        private const string _endNode = "out";
         
        internal static long CountPaths(string rawText) {

            Dictionary<string, HashSet<string>> graph = BuildGraph(rawText);
            return DFS(graph, _startNode, _endNode);
        } 
 
    } 
} 
