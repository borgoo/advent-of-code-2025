using static AdventOfCode.Core.Day5.Day5; 
 
namespace AdventOfCode.NUnit.Tests.Day5; 
 
public class Day5Part1Test 
{ 
    [Test] 
    public void Day5Part1_CountFreshIngredients_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 5, part: 1); 
        const long expected = 3; 
 
        var result = Part1.CountFreshIngredients(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day5Part1_CountFreshIngredients_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 5); 
        const long expected = 607; 
 
        var result = Part1.CountFreshIngredients(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
