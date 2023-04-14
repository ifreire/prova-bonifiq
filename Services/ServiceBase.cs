using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class ServiceBase
    {
        protected TestDbContext _ctx;

        public ServiceBase(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Entity> ListEntity<Entity>(int page, int totalCount = 10) where Entity : class
        {
            page = ((page > 0) ? page -= 1 : 0) * totalCount;
            List<Entity> result = _ctx.Set<Entity>().Skip(page).Take(totalCount).ToList();
            
            return result;
        }

        public ListBase<ListType> ListList<ListType>(int page) where ListType : class
        {
            int totalCount = 10;
            ListBase<ListType> listBase = new ListBase<ListType>();
            listBase.TotalCount = totalCount;
            listBase.HasNext = false;

            return listBase;
        }
    }
}
