using static AdventOfCode.Core.Day11.Day11; 
 
namespace AdventOfCode.NUnit.Tests.Day11; 
 
public class Day11Part1Test 
{ 
    [Test] 
    public void Day11Part1_CountPaths_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 11, part: 1); 
        const long expected = 5; 
 
        var result = Part1.CountPaths(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day11Part1_CountPaths_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 11); 
        const long expected = 788; 
 
        var result = Part1.CountPaths(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
