using static AdventOfCode.Core.Day7.Day7; 
 
namespace AdventOfCode.NUnit.Tests.Day7; 
 
public class Day7Part2Test 
{ 
    [Test] 
    public void Day7Part2_CountDifferentTimelines_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 7, part: 1); 
        const long expected = 40; 
 
        var result = Part2.CountDifferentTimelines(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day7Part2_CountDifferentTimelines_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 7); 
        const long expected = 40999072541589; 
 
        var result = Part2.CountDifferentTimelines(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
