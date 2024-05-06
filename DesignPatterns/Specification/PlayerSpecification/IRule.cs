namespace DesignPatterns.Specification.PlayerSpecification
{
	public interface IRule<in TModel>
	{
		public bool IsStatisfiedBy(TModel model);
	}
}