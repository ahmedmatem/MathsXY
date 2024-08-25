namespace MathsXY.Infrastructure.Data.Contracts
{
    public interface IAuditable
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
