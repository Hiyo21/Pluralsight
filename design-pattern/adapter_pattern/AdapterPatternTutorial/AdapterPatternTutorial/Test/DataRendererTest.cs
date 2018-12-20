using System;
using System.IO;
using System.Linq;
using AdapterPatternTutorial.Model;
using NUnit.Framework;
using Npgsql;
using AdapterPatternTutorial.Library;
using System.Collections.Generic;

namespace AdapterPatternTutorial.Test
{
	[TestFixture]
	public class DataRendererTest
    {
	    [Test]
	    public void RenderOneRowWithStubDbAdapter()
	    {
		    var myRenderer = new DataRenderer(new StubDbAdapter());

		    var writer = new StringWriter();
			myRenderer.Render(writer);

		    Console.WriteLine(writer.ToString());

		    int lineCount = writer.ToString().Count(x => x == '\n');
		    Assert.That(lineCount, Is.EqualTo(3));
	    }

	    [Test]
	    public void RenderMultipleRowsWithNpgSqlAdapter()
	    {
		    var sqlString = @"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=2249;";

			using (var connection = new NpgsqlConnection(sqlString))
		    {
			    var adapter = new NpgsqlDataAdapter();
			    adapter.SelectCommand = new NpgsqlCommand("SELECT * FROM design_pattern.adapter");
			    adapter.SelectCommand.Connection = connection;
			    var renderer = new DataRenderer(adapter);

			    var writer = new StringWriter();
			    renderer.Render(writer);
			    Console.WriteLine(writer.ToString());

			    int lineCount = writer.ToString().Count(x => x == '\n');
			    Assert.That(lineCount, Is.EqualTo(5));
			}
		}

	    [Test]
	    public void RenderOnerowWithPatternDataAdapter()
	    {
			var myRenderrer = new PatternRenderer();

		    var myList = new List<Pattern>
		    {
			    new Pattern{Id = 1, Name = "foo", Description = "bar"}, new Pattern{Id = 2, Name = "hello", Description = "world"}
		    };

		    string result = myRenderrer.RenderPatterns(myList);

		    Console.WriteLine(result);

		    int lineCount = result.Count(x => x == '\n');
		    Assert.That(lineCount, Is.EqualTo(3));
	    }
    }
}
