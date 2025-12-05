using static AdventOfCode.Core.Day5.Day5; 
 
namespace AdventOfCode.NUnit.Tests.Day5; 
 
public class Day5Part2Test 
{ 
    [Test] 
    public void Day5Part2_CountHowManyFreshIngredientsThereAre_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 5, part: 1); 
        const long expected = 14; 
 
        var result = Part2.CountHowManyFreshIngredientsThereAre(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day5Part2_CountHowManyFreshIngredientsThereAre_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 5); 
        const long expected = 342433357244012; 
 
        var result = Part2.CountHowManyFreshIngredientsThereAre(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
