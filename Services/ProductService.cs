using ProvaPub.Models;
using ProvaPub.Repository;
using System.Collections.Generic;

namespace ProvaPub.Services
{
	public class ProductService : ServiceBase
    {
        public ProductService(TestDbContext ctx) : base(ctx)
        {
        }

        public ProductList ListProducts(int page)
		{
			List<Product> list = base.ListEntity<Product>(page);

			ProductList p = new ProductList();
            base.ListList<ProductList>(page);

            return new ProductList() { HasNext = false, TotalCount = list.Count, Products = list };
        }
	}
}