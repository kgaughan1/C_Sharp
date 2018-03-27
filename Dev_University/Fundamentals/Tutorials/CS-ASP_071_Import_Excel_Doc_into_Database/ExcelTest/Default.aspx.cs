using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.IO;
using ExcelDataReader;

namespace ExcelTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // NOTE: The absolute file path has been used for the ExcelData.xlsx file.  
            // Delete the below .xlsx file path, then click and drag the "ExcelData.xlsx" 
            // file from the Solution Explorer onto the Default.aspx.cs page to obtain the
            // correct file path.

            using (var stream = File.Open("C:/Users/kgaughan/Desktop/Csharp.NET/repo/ExcelTest/ExcelTest/ExcelData.xlsx", FileMode.Open, FileAccess.Read))
            {

                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read()) // Reads row by row
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();

                    // The result of each spreadsheet is in result.Tables

                    DataGrid1.DataSource = result;
                    DataGrid1.DataBind();
                }
            }



            /*
            // Create connection string variable. Modify the "Data Source"
            // parameter as appropriate for your environment.
            String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Server.MapPath("./ExcelData.xlsx") + ";" +
            "Extended Properties=Excel 12.0 Xml;HDR=YES;";
            // Create connection object by using the preceding connection string.
            OleDbConnection objConn = new OleDbConnection(sConnectionString);

            // Open connection with the database.
            objConn.Open();

            // The code to follow uses a SQL SELECT command to display the data from the worksheet.

            // Create new OleDbCommand to return data from worksheet.
            OleDbCommand objCmdSelect =new OleDbCommand("SELECT * FROM myRange1", objConn);

            // Create new OleDbDataAdapter that is used to build a DataSet
            // based on the preceding SQL SELECT statement.
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();

            // Pass the Select command to the adapter.
            objAdapter1.SelectCommand = objCmdSelect;

            // Create new DataSet to hold information from the worksheet.
            DataSet objDataset1 = new DataSet();

            // Fill the DataSet with the information from the worksheet.
            objAdapter1.Fill(objDataset1, "XLData");

            // Bind data to DataGrid control.
            DataGrid1.DataSource = objDataset1.Tables[0].DefaultView;
            DataGrid1.DataBind();

            // Clean up objects.
            objConn.Close();

    */
        }
    }
}