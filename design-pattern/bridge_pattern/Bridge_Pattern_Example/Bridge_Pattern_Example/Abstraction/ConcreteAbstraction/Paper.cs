using System;
using System.Collections.Generic;
using System.Text;
using Bridge_Pattern_Example.NewFolder.Model;

namespace Bridge_Pattern_Example.Abstraction.ConcreteImplementation
{
    class Paper : Manuscript
    {
	    public Paper(IFormatter formatter) : base(formatter)
	    {
	    }

	    public string reporter;
	    public string date;
	    public string headline;

		public override void Print()
		{
			Console.WriteLine(formatter.Format("reporter", reporter));
			Console.WriteLine(formatter.Format("date", date));
			Console.WriteLine(formatter.Format("headline", headline));
		}
	}
}
