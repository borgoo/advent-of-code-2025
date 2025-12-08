using static AdventOfCode.Core.Day8.Day8; 
 
namespace AdventOfCode.NUnit.Tests.Day8; 
 
public class Day8Part2Test 
{ 
    [Test] 
    public void Day8Part2_Solve_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 8, part: 1); 
        const long expected = 25272; 
 
        var result = Part2.MergeAllInOneBigCircuit(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day8Part2_Solve_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 8); 
        const long expected = 27338688; 
 
        var result = Part2.MergeAllInOneBigCircuit(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
