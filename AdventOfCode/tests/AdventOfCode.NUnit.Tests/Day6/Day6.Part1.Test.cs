using static AdventOfCode.Core.Day6.Day6; 
 
namespace AdventOfCode.NUnit.Tests.Day6; 
 
public class Day6Part1Test 
{ 
    [Test] 
    public void Day6Part1_DoMath_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 6, part: 1); 
        const long expected = 4277556; 
 
        var result = Part1.DoMath(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day6Part1_DoMath_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 6); 
        const long expected = 5977759036837; 
 
        var result = Part1.DoMath(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
