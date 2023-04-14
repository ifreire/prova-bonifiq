namespace ProvaPub.Models
{
	public class CustomerList : ListBase
    {
		public CustomerList()
		{
            Customers = new List<Customer>();
        }

        public List<Customer> Customers { get; set; }
	}
}
