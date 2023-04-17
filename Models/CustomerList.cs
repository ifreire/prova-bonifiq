namespace ProvaPub.Models
{
	public class CustomerList : BaseList
    {
		public CustomerList()
		{
            Customers = new List<Customer>();
        }

        public List<Customer> Customers
        {
            get
            {
                return (List<Customer>)base.List;
            }
            set
            {
                base.List = value;
            }
        }

        public override string ToString()
        {
            return $"TotalCount {base.TotalCount} - HasNext {base.HasNext} - Count {Customers.Count}";
        }
    }
}