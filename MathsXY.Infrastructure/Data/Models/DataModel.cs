namespace MathsXY.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MathsXY.Infrastructure.Data.Contracts;

    public abstract class DataModel : IAuditable, IDeletable
    {
        [Key]
        public string Id { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
