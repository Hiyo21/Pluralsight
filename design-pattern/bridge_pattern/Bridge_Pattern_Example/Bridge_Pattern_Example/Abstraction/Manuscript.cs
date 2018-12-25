using System;
using System.Collections.Generic;
using System.Text;
using Bridge_Pattern_Example.NewFolder.Model;

namespace Bridge_Pattern_Example.Abstraction
{
	//"abstract" abstraction
	//usually, abstract abstraction cannot be an interface because an interface can't compose another interface.
	//So often times, abstract class is used to achieve inheritance.
    public abstract class Manuscript
    {
		protected readonly IFormatter formatter;

	    public Manuscript(IFormatter formatter)
	    {
		   this.formatter = formatter;
	    }

	    abstract public void Print();
    }
}
