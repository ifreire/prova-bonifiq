namespace ProvaPub.Models
{
	public class Product : BaseEntityName
    {
		public override string ToString()
        {
            return $"{base.Id} - {base.Name}";
        }
    }
}