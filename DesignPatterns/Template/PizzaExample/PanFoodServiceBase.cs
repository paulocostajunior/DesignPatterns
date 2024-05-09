using DesignPatterns.Entities;

namespace DesignPatterns.Template.PizzaExample
{
	public abstract class PanFoodServiceBase<T> where T:PanFood, new()
	{
		protected T _item;

		public void Prepare()
		{
			_item = new T();

			PrepareCrust();

			AddTopping();

			Cover();

			if (_item.RequiresBaking)
			{
				Bake();
			}

			Slice();
		}

		protected abstract void PrepareCrust();

		protected abstract void AddTopping();

		protected virtual void Bake() { Console.WriteLine("Item was baked"); }

		protected abstract void Slice();

		protected virtual void Cover() { /*nothing by default*/ }
	}
}

