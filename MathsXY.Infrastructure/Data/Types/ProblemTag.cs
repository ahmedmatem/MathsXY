namespace MathsXY.Infrastructure.Data.Types
{
    [Flags]
    public enum ProblemTag
    {
        Arithmetic = 1,
        Algebra = 2,
        Geometry = 3,
        Trigonometry = 4,
        Calculus = 8,
        ProbabilityAndStatistics = 16,
        NumberTheory = 32,
        DiscreteMaths = 64,
        LinearAlgebra = 128,
        MathsLogicAndFoundations = 256,
        AppliedMaths = 512,
        ComplexAnalysis = 1024,
        DifferentialEquations = 2048
    }
}
