namespace Week2HW.Models.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        IBookRepository Books { get; }
        Task CompleteAsync();
    }
}
