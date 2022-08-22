using Domain;

namespace Application.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAll();
        Task<Author> GetByIdAsync(Guid id);
        Author Add(Author author);
        Author Update(Author author);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
