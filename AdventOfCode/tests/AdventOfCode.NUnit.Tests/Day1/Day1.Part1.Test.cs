using static AdventOfCode.Core.Day1.Day1; 
 
namespace AdventOfCode.NUnit.Tests.Day1; 
 
public class Day1Part1Test 
{ 
    [Test] 
    public void Day1Part1_FindPassword_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 1, part: 1); 
        const int expected = 3; 
 
        var result = Part1.FindPassword(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day1Part1_FindPassword_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 1); 
        const int expected = 1043;
        const int tooLow = 695;


        var result = Part1.FindPassword(rawText); 
 
        Assert.That(result, Is.GreaterThan(tooLow)); 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
