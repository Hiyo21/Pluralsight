using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Example
{
	//Director - loosely couples builder
	public class SandwichMaker
    {
	    private readonly SandwichBuilder builder;

		public SandwichMaker(SandwichBuilder builder) => this.builder = builder;
	    public Sandwich GetSandwich() => builder.Sandwich;

		public void BuildSandwich()
	    {
			builder.CreateNewSandwich();
		    builder.PrepareBread();
		    builder.ApplyMeatAndCheese();
			builder.ApplyVegetables();
			builder.AddCondiments();
	    }
	}
}
