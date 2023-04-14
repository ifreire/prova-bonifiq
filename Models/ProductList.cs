﻿namespace ProvaPub.Models
{
	public class ProductList : BaseList
	{
		public ProductList()
		{
            Products = new List<Product>();
        }

        public List<Product> Products
        {
            get
            {
                return (List<Product>)base.List;
            }
            set
            {
                base.List = value;
            }
        }

        public override string ToString()
        {
            return $"TotalCount - {base.TotalCount}\r\nHasNext - {base.HasNext}\r\nCount - {Products.Count}";
        }
    }
}