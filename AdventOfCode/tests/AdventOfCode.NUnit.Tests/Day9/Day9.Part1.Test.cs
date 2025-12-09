using static AdventOfCode.Core.Day9.Day9; 
 
namespace AdventOfCode.NUnit.Tests.Day9; 
 
public class Day9Part1Test 
{ 
      
    [Test] 
    public void Day9Part1_FindLargestArea_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 9, part: 1); 
        const long expected = 50; 
 
        var result = Part1.FindLargestArea(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day9Part1_FindLargestArea_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 9); 
        const long expected = 4755278336; 
 
        var result = Part1.FindLargestArea(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
