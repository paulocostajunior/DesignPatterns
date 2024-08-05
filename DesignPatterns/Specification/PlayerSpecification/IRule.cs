namespace DesignPatterns.Specification.PlayerSpecification
{
	public interface IRule<in TModel>
	{
		public bool IsSatisfiedBy(TModel model);
	}
}