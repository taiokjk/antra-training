using AutoMapper;
using Azure.Core;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace Infrastructure.Service
{
    public class BaseService<Entity, Request, Response, IRepo> : IBaseService<Entity, Request, Response>
                where Entity : class
                where Request : class
                where Response : class
                where IRepo : IBaseRepository<Entity>
    {
        protected readonly IRepo _repo;
        protected readonly IMapper _mapper;

        public BaseService(IRepo r, IMapper m)
        {
            _repo = r;
            _mapper = m;
        }

        public int Create(Request requestModel)
        {
            var entity = _mapper.Map<Entity>(requestModel);
            return _repo.Create(entity);
        }

        public int Delete(int id)
        {
            return _repo.Delete(id);
        }

        public IEnumerable<Response> Filter(Func<Entity, bool> predicate)
        {
            var entities = _repo.Filter(predicate);
            var result = _mapper.Map<IEnumerable<Response>>(entities);

            return result;
        }

        public virtual IEnumerable<Response> GetAll()
        {
            var entities = _repo.GetAll();
            var result = _mapper.Map<IEnumerable<Response>>(entities);

            return result;
        }

        public virtual Response GetById(int id)
        {
            var entity = _repo.GetById(id);
            var result = _mapper.Map<Response>(entity);

            return result;
        }

        public int Update(Request requestModel)
        {
            var entity = _mapper.Map<Entity>(requestModel);
            return _repo.Update(entity);
        }
    }
}
