namespace ProvaPub.Models
{
    public class ListBase<ListType> where ListType : class
    {
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }

    }
}
