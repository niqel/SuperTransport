using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace FileProcessing
{ 
    public class IFormFileReader
    {
        private IFormFile IFormFile { get; }
        public IFormFileReader(IFormFile iFormFile)
        {
            this.IFormFile = iFormFile;
        }

        public DataSet GetDataSet(int headerRow = 0)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = IFormFile.OpenReadStream())
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var excelDataSetConfiguration = new ExcelDataSetConfiguration
                    {
                        // Gets or sets a value indicating whether to set the DataColumn.DataType 
                        // property in a second pass.
                        UseColumnDataType = true,

                        // Gets or sets a callback to determine whether to include the current sheet
                        // in the DataSet. Called once per sheet before ConfigureDataTable.
                        FilterSheet = (tableReader, sheetIndex) => {
                            return tableReader.VisibleState == "visible";
                        },

                        // Gets or sets a callback to obtain configuration options for a DataTable. 
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            // Gets or sets a value indicating whether to use a row from the 
                            // data as column names.
                            UseHeaderRow = true,

                            // Gets or sets a callback to determine which row is the header row. 
                            // Only called when UseHeaderRow = true.
                            ReadHeaderRow = (rowReader) => {
                                for (int i = 0; i < headerRow; i++)
                                {
                                    rowReader.Read();
                                }
                            },

                            // Gets or sets a callback to determine whether to include the specific
                            // column in the DataTable. Called once per column after reading the 
                            // headers.
                            FilterColumn = (rowReader, columnIndex) => {
                                return rowReader.GetValue(columnIndex) != null;
                            }
                        }
                    };

                    var result = reader.AsDataSet(excelDataSetConfiguration);
                    return result;
                }
            }
        }
    }
}
