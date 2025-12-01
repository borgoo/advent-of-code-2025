using static AdventOfCode.Core.Day1.Day1; 
 
namespace AdventOfCode.NUnit.Tests.Day1; 
 
public class Day1Part2Test 
{


    [TestCase("L168", 2)]
    [TestCase("L100", 1)]
    [TestCase("L50", 1)]
    [TestCase("L51", 1)]
    [TestCase("L49", 0)]
    [TestCase("L0", 0)]
    [TestCase("R50", 1)]
    [TestCase("R51", 1)]
    [TestCase("R49", 0)]
    [TestCase("R0", 0)]
    [TestCase("R1000", 10)]
    [TestCase("L51\r\nR20\r\nR81", 1+1+1)]
    [TestCase("L51\r\nR20\r\nR83", 1+1+1)]
    [TestCase("L150", 2)]
    [TestCase("L150\r\nR50", 2)]
    [TestCase("L50\r\nR0", 1)]
    [TestCase("L50\r\nR1", 1)]
    [TestCase("L50\r\nL1", 1)]
    [TestCase("R5\r\nL55\r\nL1", 1)]
    public void Day1Part2_FindPasswordWith0x434C49434BMethod_WhenInputReachMultipleTimesThe0_ReturnsExpectedValue(string rawText, int expected)
    {
        var result = Part2.FindPasswordWith0x434C49434BMethod(rawText);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test] 
    public void Day1Part2_FindPasswordWith0x434C49434BMethod_WithSampleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadSampleInput(day: 1, part: 2); 
        const int expected = 6; 
 
        var result = Part2.FindPasswordWith0x434C49434BMethod(rawText); 
 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
 
    [Test] 
    public void Day1Part2_FindPasswordWith0x434C49434BMethod_WithPuzzleInput_ReturnsExpectedValue() 
    { 
        string rawText = TestDataHelper.LoadPuzzleInput(day: 1); 
        const int tooLow = 5738;
        const int tooHigh = 6018;
        const int expected = 5963;


        var result = Part2.FindPasswordWith0x434C49434BMethod(rawText); 
 
        Assert.That(result, Is.GreaterThan(tooLow)); 
        Assert.That(result, Is.LessThan(tooHigh)); 
        Assert.That(result, Is.EqualTo(expected)); 
    } 
} 
