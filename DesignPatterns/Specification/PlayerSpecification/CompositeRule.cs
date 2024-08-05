namespace DesignPatterns.Specification.PlayerSpecification
{
	public abstract class CompositeRule<T> : IRule<T>
	{
        public abstract bool IsSatisfiedBy(T model);

        public CompositeRule<T> And(IRule<T> andModel)
        {
            return new AndRule<T>(this, andModel);
        }
    }
}