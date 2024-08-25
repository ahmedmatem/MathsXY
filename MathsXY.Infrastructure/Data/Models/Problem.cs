namespace MathsXY.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MathsXY.Infrastructure.Data.Types;
    using static MathsXY.Infrastructure.Data.Constants;
    public class Problem : DataModel
    {
        [Required]
        [MaxLength(ProblemStatementMaxLength)]
        public string Statement { get; set; } = null!;

        public ProblemType Type { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public string? Choices { get; set; }

        [Required]
        public string CorrectAnswer { get; set; } = null!;

        public ProblemTag Tag { get; set; }

        public int Points { get; set; }


    }
}
