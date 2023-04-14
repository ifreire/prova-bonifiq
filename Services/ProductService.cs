﻿using ProvaPub.Models;
using ProvaPub.Repository;
using System.Collections.Generic;

namespace ProvaPub.Services
{
	public class ProductService : ServiceBase
    {
		public ProductService(TestDbContext ctx)
		{
			base._ctx = ctx;
		}

		public ProductList  ListProducts(int page)
		{
			int totalCount = 10;
			page = ((page > 0) ? page -= 1 : 0) * totalCount;

            return new ProductList() { HasNext = false, TotalCount = totalCount, Products = _ctx.Products.Skip(page).Take(totalCount).ToList() };
        }

	}
}
