using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Bridge_Pattern_Example.NewFolder.Model;

namespace Bridge_Pattern_Example.Abstraction.ConcreteImplementation
{
    class OnlinePost : Manuscript
    {
	    public OnlinePost(IFormatter formatter) : base(formatter)
	    {
	    }

	    public string title;
	    public string username;
	    public string mainPost;

		public override void Print()
		{
			Console.WriteLine(formatter.Format("Title", title));
			Console.WriteLine(formatter.Format("username", username));
			Console.WriteLine(formatter.Format("mainPost", mainPost));
		}
	}
}
