namespace ProvaPub.Models
{
    public class BaseList
    {
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
        public Object List { get; set; }
    }
}