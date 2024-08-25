namespace MathsXY.Infrastructure.Data.Types
{
    /// <summary>
    /// The method or formula used to solve the problem
    /// </summary>
    [Flags]
    public enum SolutionMethod
    {
        QuadraticFormula = 1,
        PythogoreanTheorem = 2
    }
}
