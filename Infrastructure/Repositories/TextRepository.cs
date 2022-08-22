using Application.Interfaces.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TextRepository : ITextRepository
    {
        private readonly AppDbContext _appDBContext;

        public TextRepository(AppDbContext dbContext)
        {
            _appDBContext = dbContext;
        }
        public Text AddText(Text text)
        {
            var Text = _appDBContext.Texts.Add(text);
            return Text.Entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {       
            var TextDelete = await _appDBContext.Texts.FirstOrDefaultAsync(x => x.Id == id);
            if (TextDelete is null)
            {
                return false;
            }
            _appDBContext.Texts.Remove(TextDelete);

            return true;

        }

        public IQueryable<Text> GetAll()
        {
            return _appDBContext.Texts
                .Include(a => a.Author)
                .AsQueryable();
        }
        
        public async Task<Text> GetByIdAsync(Guid id)
        {
            return await _appDBContext.Texts
                .Include(a => a.Author)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
       
        public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _appDBContext.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}
