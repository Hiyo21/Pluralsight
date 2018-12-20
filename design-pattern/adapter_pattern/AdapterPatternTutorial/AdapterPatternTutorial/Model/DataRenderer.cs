using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace AdapterPatternTutorial.Model
{
    class DataRenderer
    {
	    private readonly IDbDataAdapter _dataAdapter;

	    public DataRenderer(IDbDataAdapter dataAdapter)
	    {
		    _dataAdapter = dataAdapter;
	    }

	    //WANT : make this reusable
	    public void Render(TextWriter textWriter)
	    {
			textWriter.WriteLine("Rendering data - tutorial");
		    var dataSet = new DataSet();

		    _dataAdapter.Fill(dataSet);

		    foreach (DataTable table in dataSet.Tables)
		    {
				//Writes header
			    foreach (DataColumn column in table.Columns)
			    {
					//Writes header column one by one
				    textWriter.Write(column.ColumnName.PadRight(20) + " ");
			    }
				textWriter.WriteLine();
				//Writes data
			    foreach (DataRow row in table.Rows)
			    {
				    for (int i = 0; i < table.Columns.Count; i++)
				    {
					    textWriter.Write(row[i].ToString().PadRight(20) + " ");
					}
					textWriter.WriteLine();
			    }
		    }
	    }
    }
}
