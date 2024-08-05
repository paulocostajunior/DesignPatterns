using DesignPatterns.Entities;

namespace DesignPatterns.Specification.PlayerSpecification
{
    public class PlayerFirstNameRule : CompositeRule<Player>
    {
        public override bool IsSatisfiedBy(Player model)
        {
            return string.IsNullOrEmpty(model?.FirstName) is false;
        }
    }
}