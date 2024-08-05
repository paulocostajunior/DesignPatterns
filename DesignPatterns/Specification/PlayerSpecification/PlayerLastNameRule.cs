using DesignPatterns.Entities;

namespace DesignPatterns.Specification.PlayerSpecification
{
	public class PlayerLastNameRule : CompositeRule<Player>
	{
        public override bool IsSatisfiedBy(Player model)
        {
            return string.IsNullOrEmpty(model?.LastName) is false;
        }
    }
}