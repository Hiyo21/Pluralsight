using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern_Example.NewFolder.Model
{
	// abstract implementation.
	// Shared reference for "how" to print the input values 
    public interface IFormatter
    {
	    string Format(string key, string value);
    }
}
