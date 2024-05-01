
namespace Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        int Create(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Filter(Func<T, bool> predicate);
        int Update(T entity);
        int Delete(int id);
    }
}
