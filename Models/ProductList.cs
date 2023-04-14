namespace ProvaPub.Models
{
	public class ProductList : ListBase
	{
		public ProductList()
		{
            Products = new List<Product>();
        }

		public List<Product> Products { get; set; }

        public override string ToString()
        {
            return $"TotalCount - {base.TotalCount}\r\nHasNext - {base.HasNext.ToString()}\r\nCount - {Products.Count.ToString()}";
        }
    }
}
