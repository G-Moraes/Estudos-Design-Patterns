using Exercises._3___Behavioral.Section_22___Strategy;
using System.Numerics;
using static Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_22___Strategy.StrategyTestData;

namespace Tests.Tests._3___Behavioral._22___Strategy_Tests
{
    /*
      [Test]
      public void PositiveTestOrdinaryStrategy()
      {
        var strategy = new OrdinaryDiscriminantStrategy();
        var solver = new QuadraticEquationSolver(strategy);
        var results = solver.Solve(1, 10, 16);
        Assert.That(results.Item1, Is.EqualTo(new Complex(-2, 0)));
        Assert.That(results.Item2, Is.EqualTo(new Complex(-8, 0)));
      }

      [Test]
      public void PositiveTestRealStrategy()
      {
        var strategy = new RealDiscriminantStrategy();
        var solver = new QuadraticEquationSolver(strategy);
        var results = solver.Solve(1, 10, 16);
        Assert.That(results.Item1, Is.EqualTo(new Complex(-2, 0)));
        Assert.That(results.Item2, Is.EqualTo(new Complex(-8, 0)));
      }

      [Test]
      public void NegativeTestOrdinaryStrategy()
      {
        var strategy = new OrdinaryDiscriminantStrategy();
        var solver = new QuadraticEquationSolver(strategy);
        var results = solver.Solve(1, 4, 5);
        Assert.That(results.Item1, Is.EqualTo(new Complex(-2, 1)));
        Assert.That(results.Item2, Is.EqualTo(new Complex(-2, -1)));
      }

      [Test]
      public void NegativeTestRealStrategy()
      {
        var strategy = new RealDiscriminantStrategy();
        var solver = new QuadraticEquationSolver(strategy);
        var results = solver.Solve(1, 4, 5);
        var complexNaN = new Complex(double.NaN, double.NaN);
        
        Assert.That(results.Item1, Is.EqualTo(complexNaN));
        Assert.That(results.Item2, Is.EqualTo(complexNaN));

        Assert.IsTrue(double.IsNaN(results.Item1.Real));
        Assert.IsTrue(double.IsNaN(results.Item1.Imaginary));
        Assert.IsTrue(double.IsNaN(results.Item2.Real));
        Assert.IsTrue(double.IsNaN(results.Item2.Imaginary));
      }
    
    */
    public class Strategy
    {
        [Theory]
        [ClassData(typeof(PositiveTestData))]
        public void AssertPositiveTestOrdinaryStrategy(IDiscriminantStrategy strategy, double a, double b, double c, Complex expected1, Complex expected2)
        {
            // Arrange
            var solver  = new QuadraticEquationSolver(strategy);
            
            // Act
            var results = solver.Solve(a, b, c);

            // Assert
            Assert.Equal(expected1, results.Item1);
            Assert.Equal(expected2, results.Item2);
        }

        [Theory]
        [ClassData(typeof(PositiveTestData))]
        public void AssertPositiveTestRealStrategy(IDiscriminantStrategy strategy, double a, double b, double c, Complex expected1, Complex expected2)
        {
            // Arrange
            var solver  = new QuadraticEquationSolver(strategy);

            // Act
            var results = solver.Solve(a, b, c);

            // Assert
            Assert.Equal(expected1, results.Item1);
            Assert.Equal(expected2, results.Item2);
        }

        [Theory]
        [ClassData(typeof(NegativeOrdinaryTestData))]
        public void AssertNegativeTestOrdinaryStrategy(IDiscriminantStrategy strategy, double a, double b, double c, Complex expected1, Complex expected2)
        {
            // Arrange
            var solver = new QuadraticEquationSolver(strategy);

            // Act
            var results = solver.Solve(a, b, c);

            // Assert
            Assert.Equal(expected1, results.Item1);
            Assert.Equal(expected2, results.Item2);
        }

        [Theory]
        [ClassData(typeof(NegativeRealTestData))]
        public void AssertNegativeTestRealStrategy(IDiscriminantStrategy strategy, double a, double b, double c)
        {
            // Arrange
            var solver      = new QuadraticEquationSolver(strategy);
            var complexNaN  = new Complex(double.NaN, double.NaN);

            // Act
            var results = solver.Solve(a, b, c);

            // Assert
            Assert.Equal(complexNaN, results.Item1);
            Assert.Equal(complexNaN, results.Item2);

            Assert.True(double.IsNaN(results.Item1.Real));
            Assert.True(double.IsNaN(results.Item1.Imaginary));
            Assert.True(double.IsNaN(results.Item2.Real));
            Assert.True(double.IsNaN(results.Item2.Imaginary));
        }

    }
}