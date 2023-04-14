namespace ProvaPub.Models
{
	public class ProductList : ListBase
	{
		public ProductList()
		{
            Products = new List<Product>();
        }

		public List<Product> Products { get; set; }
	}
}
