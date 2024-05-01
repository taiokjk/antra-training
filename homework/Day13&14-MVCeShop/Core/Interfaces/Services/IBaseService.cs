
namespace Core.Interfaces.Services
{
    public interface IBaseService<Entity, Request, Response> 
            where Entity : class
            where Request : class
            where Response : class
    {
        int Create(Request requestModel);
        Response GetById(int id);
        IEnumerable<Response> GetAll();
        IEnumerable<Response> Filter(Func<Entity, bool> predicate);
        int Update(Request requestModel);
        int Delete(int id);
    }
}
