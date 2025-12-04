using static AdventOfCode.Core.Day4.Day4; 
 
namespace AdventOfCode.NUnit.Tests.Day4; 
 
public class Day4Part1Test 
{ 
    [Test] 
    public void Day4Part1_GetNumOfAccessibleRollsOfPaper_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 4, part: 1); 
        const long expected = 13; 
 
        var result = Part1.GetNumOfAccessibleRollsOfPaper(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day4Part1_GetNumOfAccessibleRollsOfPaper_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 4); 
        const long expected = 1449; 
 
        var result = Part1.GetNumOfAccessibleRollsOfPaper(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
