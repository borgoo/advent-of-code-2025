using static AdventOfCode.Core.Day6.Day6; 
 
namespace AdventOfCode.NUnit.Tests.Day6; 
 
public class Day6Part2Test 
{ 
    [Test] 
    public void Day6Part2_DoVerticalMath_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 6, part: 1); 
        const long expected = 3263827; 
 
        var result = Part2.DoVerticalMath(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day6Part2_DoVerticalMath_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 6); 
        const long expected = 9630000828442; 
 
        var result = Part2.DoVerticalMath(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
