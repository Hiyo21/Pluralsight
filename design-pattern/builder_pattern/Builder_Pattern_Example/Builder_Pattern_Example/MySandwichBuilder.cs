using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Example
{
	public class MySandwichBuilder : SandwichBuilder
	{
		//Concrete Builder
		public override void AddCondiments()
		{
			sandwich.IsToasted = false;
			sandwich.HasMustard = false;
			sandwich.HasMayo = true;
		}

		public override void ApplyMeatAndCheese() => sandwich.MeatType = MeatType.Chicken;

		public override void ApplyVegetables() => sandwich.Vegetables = new List<string> { "Tomato", "Lettuce", "Onion", "Olive" };

		public override void PrepareBread() => sandwich.BreadType = BreadType.Oregano;
	}
}
