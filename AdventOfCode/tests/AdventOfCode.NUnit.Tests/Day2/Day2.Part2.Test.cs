using static AdventOfCode.Core.Day2.Day2; 
 
namespace AdventOfCode.NUnit.Tests.Day2; 
 
public class Day2Part2Test 
{ 
    [TestCase("11-22", 11 + 22, TestName = "Old only extremes are invalid")]
    [TestCase("12341234-12341235", 12341234, TestName ="One time")]
    [TestCase("123123123-123123124", 123123123, TestName ="Three times")] 
    [TestCase("1212121212-1212121213", 1212121212, TestName ="Five times")] 
    [TestCase("1111111-1111112", 1111111, TestName = "Seven times")]
    public void Day2Part2_SumAllInvalidIDs_WithMultipleTimesDigitRepetition_ReturnsExpectedValue(string rawText, long expected) 
    { 

        var result = new Part2().SumAllInvalidIDs(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day2Part2_SumAllInvalidIDs_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 2, part: 1); 
        const long expected = 4174379265; 
 
        var result = new Part2().SumAllInvalidIDs(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day2Part2_SumAllInvalidIDs_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 2); 
        const long expected = 25663320831; 
 
        var result = new Part2().SumAllInvalidIDs(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
