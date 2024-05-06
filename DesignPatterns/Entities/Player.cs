using System;

namespace DesignPatterns.Entities
{
	public class Player
	{
		public Player(
			int id,
			string firstName,
			string lastName,
			string displayName)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			DisplayName = displayName;
		}

		public int Id { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }

	}
}

