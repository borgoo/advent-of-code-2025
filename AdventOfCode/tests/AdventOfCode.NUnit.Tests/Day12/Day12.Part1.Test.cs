using static AdventOfCode.Core.Day12.Day12; 
 
namespace AdventOfCode.NUnit.Tests.Day12; 
 
public class Day12Part1Test 
{ 
    [Test] 
    public void Day12Part1_CountNumOfRegions_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 12, part: 1); 
        const long expected = 2; 
        var result = Part1.CountNumOfRegions(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day12Part1_CountNumOfRegions_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 12); 
        const long expected = 403; 
 
        var result = Part1.CountNumOfRegions(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
