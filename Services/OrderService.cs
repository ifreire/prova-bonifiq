using ProvaPub.Models;

namespace ProvaPub.Services
{
	public abstract class OrderService
	{
        public abstract Task<Order> PayOrder(decimal paymentValue, int customerId);

        //public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
        //{
        //	if (paymentMethod == "pix")
        //	{
        //		//Faz pagamento...
        //	}
        //	else if (paymentMethod == "creditcard")
        //	{
        //		//Faz pagamento...
        //	}
        //	else if (paymentMethod == "paypal")
        //	{
        //		//Faz pagamento...
        //	}

        //	return await Task.FromResult( new Order()
        //	{
        //		Value = paymentValue
        //	});
        //}
    }
}