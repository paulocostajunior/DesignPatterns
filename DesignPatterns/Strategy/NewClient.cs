namespace DesignPatterns.Strategy
{
    public class NewClient : IDiscount
    {
        public void CalculateDiscount()
        {
            Console.WriteLine("Calculating new client discount");
        }
    }
}
