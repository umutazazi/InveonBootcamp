
using Microsoft.EntityFrameworkCore;

namespace Week2HW.Models.Repositories
{
    public class UnitOfWork(AppDbContext appDbContext, IBookRepository bookRepository) : IUnitOfWork
    {

        public async Task CompleteAsync()
        {
            await appDbContext.SaveChangesAsync();
        }
        public IBookRepository Books => bookRepository ??= new BookRepository(appDbContext);

        public void Dispose()
        {
            appDbContext.Dispose();
        }



    }
}
