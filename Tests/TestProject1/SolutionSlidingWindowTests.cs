using CSharpSandbox;

[TestFixture]
public class SolutionSlidingWindowTests
{
    [Test]
    public void LengthOfLongestSubstring_ReturnsZero_WhenGivenEmptyString()
    {
        // Arrange
        var solution = new SolutionSlidingWindow();

        // Act
        var result = solution.LengthOfLongestSubstring("");

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void LengthOfLongestSubstring_ReturnsOne_WhenGivenStringWithOneCharacter()
    {
        // Arrange
        var solution = new SolutionSlidingWindow();

        // Act
        var result = solution.LengthOfLongestSubstring("a");

        // Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void LengthOfLongestSubstring_ReturnsCorrectLength_WhenGivenStringWithNoRepeatingCharacters()
    {
        // Arrange
        var solution = new SolutionSlidingWindow();

        // Act
        var result = solution.LengthOfLongestSubstring("abcde");

        // Assert
        Assert.AreEqual(5, result);
    }

    [Test]
    public void LengthOfLongestSubstring_ReturnsCorrectLength_WhenGivenStringWithRepeatingCharacters()
    {
        // Arrange
        var solution = new SolutionSlidingWindow();

        // Act
        var result = solution.LengthOfLongestSubstring("abcabcbb");

        // Assert
        Assert.AreEqual(3, result);
    }
}