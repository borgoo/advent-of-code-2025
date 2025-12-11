using static AdventOfCode.Core.Day10.Day10; 
 
namespace AdventOfCode.NUnit.Tests.Day10; 
 
public class Day10Part1Test 
{ 
    [Test] 
    public void Day10Part1_ConfigureIndicatorLights_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 10, part: 1); 
        const long expected = 7; 
 
        var result = Part1.ConfigureIndicatorLights(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day10Part1_ConfigureIndicatorLights_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 10); 
        const long expected = 517; 
 
        var result = Part1.ConfigureIndicatorLights(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
