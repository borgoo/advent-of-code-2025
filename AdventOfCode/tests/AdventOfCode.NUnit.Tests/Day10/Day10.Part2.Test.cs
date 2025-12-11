using static AdventOfCode.Core.Day10.Day10; 
 
namespace AdventOfCode.NUnit.Tests.Day10; 
 
public class Day10Part2Test 
{ 
    [Test] 
    public void Day10Part2_ConfigureJoltageLevels_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 10, part: 1); 
        const long expected = 33; 
 
        var result = Part2.ConfigureJoltageLevels(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day10Part2_ConfigureJoltageLevels_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 10); 
        const long expected = 21469; 
 
        var result = Part2.ConfigureJoltageLevels(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
