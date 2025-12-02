using static AdventOfCode.Core.Day2.Day2; 
 
namespace AdventOfCode.NUnit.Tests.Day2; 
 
public class Day2Part1Test 
{ 

    [TestCase("11-22", 11+22, TestName ="Only extremes are invalid")] 
    [TestCase("95-115", 99, TestName ="Invalid value in the middle")] 
    [TestCase("1698522-1698528", 0, TestName ="No invalid values")] 
    public void Day2Part1_SumAllInvalidIDs_WhenSpecificRangesArePassed_ReturnsExpectedValue(string rawText, long expected) 
    {  
        var result = new Part1().SumAllInvalidIDs(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 

    
    [Test] 
    public void Day2Part1_SumAllInvalidIDs_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 2, part: 1); 
        const long expected = 1227775554;
 
        var result = new Part1().SumAllInvalidIDs(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day2Part1_SumAllInvalidIDs_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 2); 
        const long expected = 8576933996; 
 
        var result = new Part1().SumAllInvalidIDs(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
