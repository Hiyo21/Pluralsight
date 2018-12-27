using System;
using System.Collections.Generic;

namespace Builder_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
			//composes builder -> Calls director 
			var maker = new SandwichMaker(new MySandwichBuilder());
			maker.BuildSandwich();
	        maker.GetSandwich().Display();
	        Console.ReadKey();
        }
    }
}
