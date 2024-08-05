using System;
namespace DesignPatterns.Entities
{
	public class Customer
	{
		public DateTime? DateOfFirstPurchase { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int NumberOfPurchases { get; set; }
		public bool IsVeteran { get; set; }
	}
}

