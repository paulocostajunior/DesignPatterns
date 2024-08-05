namespace DesignPatterns.Specification.PlayerSpecification
{
    internal class AndRule<T> : CompositeRule<T>
    {
        private readonly IRule<T> _left;
        private readonly IRule<T> _right;

        public AndRule(IRule<T> left, IRule<T> right)
        {
            _left = left;
            _right= right;
        }

        public override bool IsSatisfiedBy(T model)
        {
            return _left.IsSatisfiedBy(model) && _right.IsSatisfiedBy(model);
        }
    }
}