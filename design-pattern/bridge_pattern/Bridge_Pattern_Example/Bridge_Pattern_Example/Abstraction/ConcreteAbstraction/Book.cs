using System;
using System.Collections.Generic;
using System.Text;
using Bridge_Pattern_Example.NewFolder.Model;

namespace Bridge_Pattern_Example.Abstraction.ConcreteImplementation
{
	class Book : Manuscript
	{
		public Book(IFormatter formatter) : base(formatter)
		{
		}

		public string title;
		public string author;
		public string text;

		public override void Print()
		{
			Console.WriteLine(formatter.Format("Title", title));
			Console.WriteLine(formatter.Format("Author", author));
			Console.WriteLine(formatter.Format("Text", text));
		}
	}
}
