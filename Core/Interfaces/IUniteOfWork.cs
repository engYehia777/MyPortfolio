namespace Core.Interfaces
{
    public interface IUniteOfWork<T> where T : class
    {
        IGenericRepository<T> Entity { get; }
        void Save();
    }
}
