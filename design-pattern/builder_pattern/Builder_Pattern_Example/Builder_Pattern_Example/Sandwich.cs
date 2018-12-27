using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Example
{
    public class Sandwich
    {
	    public bool IsToasted { get; set; }
	    public CheeseType CheeseType { get; set; }
	    public MeatType MeatType { get; set; }
	    public bool HasMustard { get; set; }
	    public bool HasMayo { get; set; }
	    public List<string> Vegetables { get; set; }
		public BreadType BreadType { get; set; }

		internal void Display()
		{
			Console.WriteLine("BreadType : {0}, MeatType : {1}, CheeseType : {2}, HasMayo : {3}, HasMustard : {4}, IsToasted : {5}, Vegetables : {6} "
				, BreadType.ToString(), MeatType.ToString(), CheeseType.ToString(), HasMayo.ToString(), HasMustard.ToString(), IsToasted.ToString(), String.Join(',', Vegetables));
		}
	}

	public enum BreadType
	{
		Wheat,
		White,
		Oregano
	}

	public enum CheeseType
	{
		PepperJack,
		Cheddar,
		Mozzarella
	}

	public enum MeatType
	{
		Beef,
		Chicken,
		Pork
	}
}
