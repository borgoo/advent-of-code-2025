using static AdventOfCode.Core.Day3.Day3; 
 
namespace AdventOfCode.NUnit.Tests.Day3; 
 
public class Day3Part2Test 
{ 
    [TestCase("987654321111111", 987654321111, TestName = "From sample input 1")]
    [TestCase("811111111111119", 811111111119, TestName = "From sample input 2")]
    [TestCase("234234234234278", 434234234278, TestName = "From sample input 3")]
    [TestCase("818181911112111", 888911112111, TestName = "From sample input 4")]
    public void Day3Part2_GetJoltage_WhenSingleBankIsPassed_ReturnsExpectedValue(string bank, long expected) 
    { 
        var result = Part2.GetJoltage(bank); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 

    [Test] 
    public void Day3Part2_GetJoltage_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 3, part: 1); 
        const long expected = 3121910778619; 
        var result = Part2.GetJoltage(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day3Part2_GetJoltage_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 3); 
        const long expected = 167384358365132; 
 
        var result = Part2.GetJoltage(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
