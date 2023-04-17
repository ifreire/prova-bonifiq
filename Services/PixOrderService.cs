using ProvaPub.Models;

namespace ProvaPub.Services
{
    public class PixOrderService : OrderService
    {
        public PixOrderService()
        {
        }

        public override async Task<Order> PayOrder(decimal paymentValue, int customerId)
        {
            //Faz pagamento...

            return await Task.FromResult(new Order()
            {
                Value = paymentValue
            });
        }
    }
}