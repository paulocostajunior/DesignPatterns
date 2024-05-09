﻿namespace DesignPatterns.Template.PizzaExample.Inheritance
{
	public abstract class TemplateBase
	{
		private bool _importantSetting;
		public void Do()
		{
			BeforeDoing();
			Initialize();
			AfterDone();
		}

		public virtual void BeforeDoing() { }
		public abstract void AfterDone();
		private void Initialize()
		{
			_importantSetting = true;
		}
	}
}