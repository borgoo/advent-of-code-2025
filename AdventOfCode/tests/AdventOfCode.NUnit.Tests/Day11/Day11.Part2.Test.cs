using static AdventOfCode.Core.Day11.Day11; 
 
namespace AdventOfCode.NUnit.Tests.Day11; 
 
public class Day11Part2Test 
{ 
 
    [Test] 
    public void Day11Part2_TailorMade_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 11); 
        const long expected = 316291887968000; 
 
        var result = Part2.TailorMade(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
