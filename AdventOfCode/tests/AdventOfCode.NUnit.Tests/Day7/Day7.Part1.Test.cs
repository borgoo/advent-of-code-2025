using static AdventOfCode.Core.Day7.Day7; 
 
namespace AdventOfCode.NUnit.Tests.Day7; 
 
public class Day7Part1Test 
{ 
    [Test] 
    public void Day7Part1_CountBeamSplitting_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 7, part: 1); 
        const long expected = 21; 
 
        var result = Part1.CountBeamSplitting(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day7Part1_CountBeamSplitting_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 7); 
        const long expected = 1640; 
 
        var result = Part1.CountBeamSplitting(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
