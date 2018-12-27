using System;
using System.Collections.Generic;
using Bridge_Pattern_Example.Abstraction;
using Bridge_Pattern_Example.Abstraction.ConcreteImplementation;
using Bridge_Pattern_Example.Implementation.ConcreteImplementation;
using Bridge_Pattern_Example.NewFolder.Model;

namespace Bridge_Pattern_Example
{
    class Program
    {
		//Client
        static void Main(string[] args)
        {
			//Implementation. Client chooses which concrete implementation (in this case, an action) to use.
	        IFormatter standardFormatter = new StandardFormatter();
			IFormatter reverseFormatter = new ReverseFormatter();

			//Abstraction. Likewise, client chooses which concrete abstraction (in this case, a subject) to use.
			Manuscript book = new Book(standardFormatter) { author = "me", text = "hello bridge pattern", title = "design pattern"};

			Manuscript paper = new Paper(reverseFormatter) {date = "2018-12-25", headline = "abcdefg", reporter = "Chris"};

			Manuscript onlinePost = new OnlinePost(standardFormatter) {title = "facebook" ,mainPost = "blah blah", username = "h.lee"};
			
	        //↑ decoupled! Manuscript is independent from formatter as long as client does its job properlhy. 
	        List<Manuscript> manuscripts = new List<Manuscript>();
			manuscripts.Add(book);
			manuscripts.Add(paper);
			manuscripts.Add(onlinePost);

	        foreach (var manuscript in manuscripts)
	        {
		        manuscript.Print();
	        }

	        Console.ReadKey();
        }
    }
}
