using ProvaPub.Models;

namespace ProvaPub.Services
{
    public interface IPixOrderService
    {
        Task<Order> PayOrder(decimal paymentValue, int customerId);
    }
}