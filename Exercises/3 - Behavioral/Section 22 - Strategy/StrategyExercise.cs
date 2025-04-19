using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3___Behavioral.Section_22___Strategy
{
    /*
    
    Consider the quadratic equation and its canonical solution:

    ax^2 + bx + c = 0
    
    x = (-b +- sqrt(b^2 4ac)) / 2a

    The part b^2-4*a*c is called the discriminant. Suppose we want to provide an API with two different strategies for calculating the discriminant:

        - In OrdinaryDiscriminantStrategy, If the discriminant is negative, we return it as-is. This is OK, since our main API returns Complex  numbers anyway.
        - In RealDiscriminantStrategy, if the discriminant is negative, the return value is NaN (not a number). NaN propagates throughout the calculation, so the equation solver gives two NaN values.

    Please implement both of these strategies as well as the equation solver itself. With regards to plus-minus in the formula, please return the + result as the first element and - as the second.
    */

    public interface IDiscriminantStrategy
    {
        double CalculateDiscriminant(double a, double b, double c);
    }

    public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        // todo
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double result = ((b * b) - (4 * a * c));

            return result;
        }
    }

    public class RealDiscriminantStrategy : IDiscriminantStrategy
    {
        // todo (return NaN on negative discriminant!)
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double result = ((b * b) - (4 * a * c));

            if(result < 0)
            {
                return double.NaN;
            }

            return result;
        }
    }

    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            double discriminant = strategy.CalculateDiscriminant(a, b, c);

            Complex sqrtDiscriminant = Complex.Sqrt(discriminant);
            Complex denom = 2 * a;

            Complex root1 = (-b + sqrtDiscriminant) / denom;
            Complex root2 = (-b - sqrtDiscriminant) / denom;

            return Tuple.Create(root1, root2);
        }
    }
}
