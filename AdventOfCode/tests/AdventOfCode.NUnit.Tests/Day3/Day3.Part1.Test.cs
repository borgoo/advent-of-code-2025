using static AdventOfCode.Core.Day3.Day3; 
 
namespace AdventOfCode.NUnit.Tests.Day3; 
 
public class Day3Part1Test 
{ 

    [TestCase("111181", 81, TestName = "All digits are the same except the last but one")] 
    [TestCase("111111", 11, TestName = "All digits are the same")] 
    [TestCase("1111891", 91, TestName = "89 seems big but 91 is bigger")] 
    [TestCase("765432", 76, TestName = "Desc order")] 
    [TestCase("1113", 13, TestName = "Exactly on the last digit")] 
    public void Day3Part1_GetJoltage_WhenSingleBankIsPassed_ReturnsExpectedValue(string bank, int expected) 
    { 

        var result = Part1.GetJoltage(bank); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 

    [Test] 
    public void Day3Part1_GetJoltage_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 3, part: 1); 
        const long expected = 357; 
 
        var result = Part1.GetJoltage(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day3Part1_GetJoltage_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 3); 
        const long expected = 16927; 
 
        var result = Part1.GetJoltage(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
