namespace TemplateMethodPattern
{
    public abstract class OrderBase
    {
        public int CreateOrder(Order order)
        {
            ValidateOrder(order);
            CheckAvailability(order.ProductId);
            var paymentId = DeductPayment(order);
            var orderId = SaveOrder(order, paymentId);
            Ship();

            return orderId;
        }

        protected virtual void ValidateOrder(Order order)
        {
            if (order.ProductId <= 0)
                throw new Exception("Order is invalid");

            Console.WriteLine("Validating order ...");
        }

        protected virtual void CheckAvailability(int productId)
        {
            Console.WriteLine("Checking availability ...");
        }

        protected abstract int DeductPayment(Order order);

        private static int SaveOrder(Order order, int paymentId)
        {
            Console.WriteLine("Saving order ...");
            return 1;
        }

        protected virtual void Ship() { }
    }
}
