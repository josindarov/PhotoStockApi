using System.Runtime.CompilerServices;
using Application.DTO.Texts;

namespace Application.Services.TextServices
{
    public partial class TextService
    {
        public async Task<bool> DeleteTextAsync(Guid id)
        {
            var isDeleted = await this.textrepository.DeleteAsync(id);
            await this.textrepository.SaveChangesAsync();
            return isDeleted;
        }
    }
}
