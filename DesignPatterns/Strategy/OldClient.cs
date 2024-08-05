namespace DesignPatterns.Strategy
{
    public class OldClient : IDiscount
    {
        public void CalculateDiscount()
        {
			Console.WriteLine("Calculating old client discount");
        }
    }
}
