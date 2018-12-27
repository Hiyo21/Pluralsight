using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Builder_Pattern_Example
{
	//Abstract Builder - can have several concrete builder types 
    public abstract class SandwichBuilder
    {
	    protected Sandwich sandwich;

		public Sandwich Sandwich => sandwich;

		public void CreateNewSandwich()
	    {
			sandwich = new Sandwich();
	    }

	    public abstract void AddCondiments();

	    public abstract void ApplyVegetables();

	    public abstract void ApplyMeatAndCheese();

	    public abstract void PrepareBread();
    }
}
