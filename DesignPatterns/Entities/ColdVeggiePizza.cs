namespace DesignPatterns.Entities
{
	public class ColdVeggiePizza : PanFood
	{
		public ColdVeggiePizza()
		{
            base.RequiresBaking = false;
		}
	}
}