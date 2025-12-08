using static AdventOfCode.Core.Day8.Day8; 
 
namespace AdventOfCode.NUnit.Tests.Day8; 
 
public class Day8Part1Test 
{ 
    [Test] 
    public void Day8Part1_MulSizeOfBiggestCircuits_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 8, part: 1); 
        const long expected = 40;
        const int wiresLimit = 10;
 
        var result = Part1.MulSizeOfBiggestCircuits(rawText, wiresLimit); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day8Part1_MulSizeOfBiggestCircuits_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 8);
        const long tooLow = 111965;
        const long tooHigh = 34252440;
        const long tooHigh2 = 5252000;

        const long expected = 123930; 
        const int wiresLimit = 1000;
 
        var result = Part1.MulSizeOfBiggestCircuits(rawText, wiresLimit); 
 
        Assert.That(result, Is.GreaterThan(tooLow)); 
        Assert.That(result, Is.LessThan(tooHigh)); 
        Assert.That(result, Is.LessThan(tooHigh2)); 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
