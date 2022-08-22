using Application.Interfaces.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext _appDbContext;
        public AuthorRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }
        public Author Add(Author author)
        {
            var addedAuthor = _appDbContext.Authors.Add(author);
            return addedAuthor.Entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var author = await _appDbContext.Authors.FirstOrDefaultAsync(a => a.Id == id);
            
            if (author is null)
            {
                return false;
            }
            
            _appDbContext.Authors.Remove(author);
            
            return true;
        }


        public IQueryable<Author> GetAll()
        {
            return _appDbContext.Authors.AsQueryable();
        }

        public async Task<Author> GetByIdAsync(Guid id)
        {
            return await _appDbContext.Authors.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _appDbContext.SaveChangesAsync(cancellationToken) > 0;
        }

        public Author Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
