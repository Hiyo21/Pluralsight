using AdapterPatternTutorial.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace AdapterPatternTutorial.Model
{
	//Client class
    public class PatternRenderer
    {
	    private readonly IExampleDataRendererAdapter _exampleDataRenderer;

	    public PatternRenderer(IExampleDataRendererAdapter exampleDataRenderer)
	    {
		    _exampleDataRenderer = exampleDataRenderer;
	    }

		public PatternRenderer() : this(new ExampleDataRendererAdapter()) { }

	    public string RenderPatterns(IEnumerable<Pattern> patterns)
	    {
		    return _exampleDataRenderer.Render(patterns);
	    }
    }

    //Adapter Interface
	public interface IExampleDataRendererAdapter
	{
		string Render(IEnumerable<Pattern> patterns);
	}

	//Adapter Implementation
	public class ExampleDataRendererAdapter : IExampleDataRendererAdapter
	{
		private DataRenderer _dataRenderer;

		public string Render(IEnumerable<Pattern> patterns)
		{
			//set Adaptee method
			var adapter = new PatternCollectionAdapter();
			var writer = new StringWriter();
			//send adaptee to renderer
			_dataRenderer = new DataRenderer(adapter);
			_dataRenderer.Render(writer);
			return writer.ToString();
		}

		//Adaptee
		internal class PatternCollectionAdapter : IDbDataAdapter
		{
			public int Fill(DataSet dataSet)
			{
				var dataTable = new DataTable();
				dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
				dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
				dataTable.Columns.Add(new DataColumn("Description", typeof(string)));

				var dataRow = dataTable.NewRow();
				dataRow[0] = 1;
				dataRow[1] = "first";
				dataRow[2] = "is first row";
				dataTable.Rows.Add(dataRow);
				dataSet.Tables.Add(dataTable);
				dataSet.AcceptChanges();

				return 1;
			}

			#region
			public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
			public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
			public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
			public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
			public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
			public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

			public ITableMappingCollection TableMappings => throw new NotImplementedException();


			public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
			{
				throw new NotImplementedException();
			}

			public IDataParameter[] GetFillParameters()
			{
				throw new NotImplementedException();
			}

			public int Update(DataSet dataSet)
			{
				throw new NotImplementedException();
			}
			#endregion
		}

	}
}
