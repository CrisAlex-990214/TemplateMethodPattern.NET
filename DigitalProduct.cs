namespace TemplateMethodPattern
{
    public class DigitalProduct : OrderBase
    {
        protected override int DeductPayment(Order order)
        {
            Console.WriteLine("Deducting payment from a digital product...");
            return 2;
        }
    }
}
