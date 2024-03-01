using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string emptyString = "";

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(emptyString);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string singleWord = "exercise";

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(singleWord);

        // Assert
        Assert.AreEqual("exercise", result);
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string multipleWords = "random string example";

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(multipleWords);

        // Assert
        Assert.AreEqual("randomStringExample", result);
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string mixedCaseWords = "RaNdOm StRiNg ExAmPlE";

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(mixedCaseWords);

        // Assert
        Assert.AreEqual("randomStringExample", result);
    }
}
