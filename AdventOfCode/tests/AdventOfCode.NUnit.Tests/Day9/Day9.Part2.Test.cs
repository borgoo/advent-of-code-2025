using static AdventOfCode.Core.Day9.Day9; 
 
namespace AdventOfCode.NUnit.Tests.Day9; 
 
public class Day9Part2Test 
{ 
    [Test] 
    public void Day9Part2_FindLargestAreaInscripted_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 9, part: 1); 
        const long expected = 24; 
 
        var result = Part2.FindLargestAreaInscripted(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day9Part2_FindLargestAreaInscripted_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 9); 
        const long expected = 1534043700; 
 
        var result = Part2.FindLargestAreaInscripted(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
