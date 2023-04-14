namespace ProvaPub.Models
{
	public class Customer : BaseEntityName
    {
		public ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return $"{base.Id} - {base.Name} - Orders {Orders.Count}";
        }
    }
}
