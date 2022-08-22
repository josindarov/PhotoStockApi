using Domain;

namespace Application.Interfaces.Repositories
{
    public interface ITextRepository
    {
        IQueryable<Text> GetAll();
        Task<Text> GetByIdAsync(Guid id);
        Task<bool> DeleteAsync(Guid id);
        Text AddText(Text text);
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
