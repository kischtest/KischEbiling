using KischEbilling.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Formatting.FormatStrings;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Utils;


namespace KischEbilling
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MyCommand = new DelegateCommand(OnCommandExecuted);
            SubmitCommand = new DelegateCommand(OnSubmitCommandExecuted);
        }
        List<InvoiceRecord> data;
        public ICommand MyCommand { get; set; }
        public ICommand SubmitCommand { get; set; }
       
        private void OnCommandExecuted(object obj)
        {

            using (var ctx = new TE_3E_PRODEntities())
            {
              data = ctx.Database.SqlQuery<InvoiceRecord>("SELECT [InvMasterID],[InvDate],[InvNumber] FROM[TE_3E_PROD].[dbo].[InvMaster] where InvNumber = 'I03-0008915'; ", new SqlParameter("@case_id", 277761)).ToList();

            }
                //string fileName = @"C:\Ebiling\InvoiceListUpload.xlsx";
                //if (!File.Exists(fileName))
                //{
                //    throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
                //}

                //Telerik.Windows.Documents.Spreadsheet.Model.Workbook workbook;
                //IWorkbookFormatProvider formatProvider = new Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx.XlsxFormatProvider();

                //using (Stream input = new FileStream(fileName, FileMode.Open))
                //{
                //    workbook = formatProvider.Import(input);
                //}


                XlsxFormatProvider formatProvider = new XlsxFormatProvider();
            Workbook workbook = formatProvider.Import(File.ReadAllBytes(@"C:\Ebiling\InvoiceListUpload.xlsx"));

            var worksheet = workbook.Sheets[0] as Worksheet;
            var table = new DataTable();


            for (int i = 0; i < worksheet.UsedCellRange.ColumnCount; i++)
            {
                CellSelection selection = worksheet.Cells[0, i];
                var columnName = selection.GetValue().Value.RawValue.ToString();

                table.Columns.Add(columnName);
            }


            for (int i = 1; i < worksheet.UsedCellRange.RowCount; i++)
            {
                var values = new object[worksheet.UsedCellRange.ColumnCount];

                for (int j = 0; j < worksheet.UsedCellRange.ColumnCount; j++)
                {
                    CellSelection selection = worksheet.Cells[i, j];

                    ICellValue value = selection.GetValue().Value;
                    CellValueFormat format = selection.GetFormat().Value;
                    CellValueFormatResult formatResult = format.GetFormatResult(value);
                    string result = formatResult.InfosText;

                    values[j] = result;
                }
                table.Rows.Add(values);

            }
             
            foreach(DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    MessageBox.Show(row[col].ToString());

                }
            }
        }

        
        private void OnCreateANewDocCommandExecuted(object obj)
        {
            //var patentTransactionBody = new LxSerializer<PatentTransactionElm>();

        }

        //public void MyDeserializerErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, TextLocation location, object targetObject)
        //{
        //    if (severity == LxErrorSeverity.Error)
        //        Console.WriteLine(msg);
        //    else if (severity == LxErrorSeverity.Warning)
        //        Console.WriteLine(msg);
        //}
    }
}
