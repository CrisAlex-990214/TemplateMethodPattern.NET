namespace TemplateMethodPattern
{
    public class PhysicalProduct : OrderBase
    {
        protected override void CheckAvailability(int productId)
        {
            Console.WriteLine("Checking stock...");
        }

        protected override int DeductPayment(Order order)
        {
            Console.WriteLine("Deducting payment for a physical product ...");
            return 1;
        }

        protected override void Ship()
        {
            Console.WriteLine("Shipping product...");
        }

        protected override void ValidateOrder(Order order)
        {
            base.ValidateOrder(order);

            if (order.AddressId <= 0)
                throw new Exception("Invalid order");
        }
    }
}
