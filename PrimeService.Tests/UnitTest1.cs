namespace PrimeService.Tests;
using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Solve_TwoRealRoots_ReturnsTwoSolutions()
    {
        // Arrange
        double a = 1, b = -3, c = 2;

        // Act
        var result =  HelloWorld.Program.Solve(a, b, c);

        // Assert
        // Assert.Equals(2, result.count);
        Assert.That(2, Is.EqualTo(result.count));
        // Assert.Equals("2", result.sol1); // First solution
        // Assert.Equals(1, result.sol2);  // Second solution
        Assert.That("2", Is.EqualTo(result.sol1));
        Assert.That(1, Is.EqualTo(result.sol2));
        
    }

        // [Test]
        // public void Solve_OneRealRoot_ReturnsOneSolution()
        // {
        //     // Arrange
        //     double a = 1, b = -2, c = 1;

        //     // Act
        //     HelloWorld.Solution result =HelloWorld.Program.Solve(a, b, c);

        //     // Assert
        //     Assert.AreEqual(1, result.count);
        //     Assert.AreEqual("1", result.sol1); // Single root
        // }

        // [Test]
        // public void Solve_NoRealRoots_ReturnsNoSolutions()
        // {
        //     // Arrange
        //     double a = 1, b = 0, c = 1;

        //     // Act
        //     HelloWorld.Solution result = HelloWorld.Program.Solve(a, b, c);

        //     // Assert
        //     Assert.AreEqual(0, result.count);
        //     Assert.IsNull(result.sol1);
        // }

        // [Test]
        // public void Solve_LinearEquation_ReturnsOneSolution()
        // {
        //     // Arrange
        //     double a = 0, b = 2, c = -4;

        //     // Act
        //     HelloWorld.Solution result = HelloWorld.Program.Solve(a, b, c);

        //     // Assert
        //     Assert.AreEqual(1, result.count);
        //     Assert.AreEqual("2", result.sol1); // Solution for linear equation
        // }

        // [Test]
        // public void Solve_InvalidEquation_ReturnsNoSolutions()
        // {
        //     // Arrange
        //     double a = 0, b = 0, c = 5;

        //     // Act
        //     HelloWorld.Solution result = HelloWorld.Program.Solve(a, b, c);

        //     // Assert
        //     Assert.AreEqual(0, result.count);
        //     Assert.IsNull(result.sol1);
}
