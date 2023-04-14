﻿namespace ProvaPub.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
