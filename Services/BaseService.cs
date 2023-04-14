using ProvaPub.Models;
using ProvaPub.Repository;
using System.Collections.Generic;

namespace ProvaPub.Services
{
    public class BaseService
    {
        protected TestDbContext _ctx;

        public BaseService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public BaseList List<Entity>(int page, int totalCount)
            where Entity    : class
        {
            List<Entity> list = getListEntities<Entity>(page, totalCount);
            BaseList listBase = new BaseList();
            listBase.HasNext = false;
            listBase.List = list;
            listBase.TotalCount = list.Count;

            return listBase;
        }

        public List<Entity> getListEntities<Entity>(int page, int totalCount)
            where Entity : class
        {
            page = ((page > 0) ? page -= 1 : 0) * totalCount;
            return _ctx.Set<Entity>().Skip(page).Take(totalCount).ToList();
        }
    }
}