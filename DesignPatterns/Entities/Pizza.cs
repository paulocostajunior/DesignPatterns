using System;
namespace DesignPatterns.Entities
{
	public class Pizza : PanFood
	{
		public string CrustType{ get; set; } = "No Crust";
		public int NumSlices { get; set; } = 1;
		public List<string> Toppings { get; private set; } = new List<string>();
		public bool WasBaked { get; set; }
	}
}

