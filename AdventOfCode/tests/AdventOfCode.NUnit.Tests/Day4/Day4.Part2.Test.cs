using static AdventOfCode.Core.Day4.Day4; 
 
namespace AdventOfCode.NUnit.Tests.Day4; 
 
public class Day4Part2Test 
{ 
    [Test] 
    public void Day4Part2_GetHowManyRollsOfPaperCanBeRemoved_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 4, part: 1); 
        const long expected = 43; 
 
        var result = Part2.GetHowManyRollsOfPaperCanBeRemoved(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day4Part2_GetHowManyRollsOfPaperCanBeRemoved_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 4); 
        const long expected = 8746; 
 
        var result = Part2.GetHowManyRollsOfPaperCanBeRemoved(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
