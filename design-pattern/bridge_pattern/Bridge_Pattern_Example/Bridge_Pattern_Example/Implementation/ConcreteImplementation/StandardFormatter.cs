using System;
using System.Collections.Generic;
using System.Text;
using Bridge_Pattern_Example.NewFolder.Model;

namespace Bridge_Pattern_Example.Implementation.ConcreteImplementation
{
	class StandardFormatter : IFormatter
	{
		public string Format(string key, string value)
		{
			return string.Format("{0} : {1}", key, value);
		}
	}
}
