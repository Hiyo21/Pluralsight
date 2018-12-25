using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge_Pattern_Example.NewFolder.Model;

namespace Bridge_Pattern_Example.Implementation.ConcreteImplementation
{
	//concrete implementation. Specifies how to format the input string.
	class ReverseFormatter : IFormatter
	{
		public string Format(string key, string value)
		{
			return string.Format("{0} : {1}", key, new string(value.Reverse().ToArray()));
		}
	}
}
