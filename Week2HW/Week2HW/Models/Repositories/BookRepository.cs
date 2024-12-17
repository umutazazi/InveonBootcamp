using Microsoft.EntityFrameworkCore;

namespace Week2HW.Models.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly AppDbContext _appDbContext;   
        private readonly DbSet<Book> _dbSet;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = appDbContext.Set<Book>();
        }

        public async Task AddAsync(Book book)
        {
          await _dbSet.AddAsync(book);
          await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if (book != null)
            {
                _dbSet.Remove(book);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
           return await _dbSet.ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(Book book)
        {
           _dbSet.Update(book);
            await _appDbContext.SaveChangesAsync(); 

        }
    }
}
