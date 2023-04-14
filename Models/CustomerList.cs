namespace ProvaPub.Models
{
	public class CustomerList : ListBase<CustomerList>
    {
		public CustomerList()
		{
            Customers = new List<Customer>();
        }

        public List<Customer> Customers { get; set; }

        public override string ToString()
        {
            return $"TotalCount - {base.TotalCount}\r\nHasNext - {base.HasNext.ToString()}\r\nCount - {Customers.Count.ToString()}";
        }
    }
}