using DesignPatterns.Entities;

namespace DesignPatterns.Specification.PlayerSpecification
{
    public class PlayerFirstNameRule : CompositeRule<Player>
    {
        public override bool IsStatisfiedBy(Player model)
        {
            return string.IsNullOrEmpty(model?.FirstName) is false;
        }
    }
}