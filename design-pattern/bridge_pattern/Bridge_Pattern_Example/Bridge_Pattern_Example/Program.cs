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
			//Implementation 
	        IFormatter standardFormatter = new StandardFormatter();
			IFormatter reverseFormatter = new ReverseFormatter();

			//Abstraction
			Manuscript book = new Book(standardFormatter) { author = "me", text = "hello bridge pattern", title = "design pattern"};

			Manuscript paper = new Paper(reverseFormatter) {date = "2018-12-25", headline = "abcdefg", reporter = "Chris"};

			Manuscript onlinePost = new OnlinePost(standardFormatter) {title = "facebook" ,mainPost = "blah blah", username = "h.lee"};

			//↑ decoupled!
		
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
