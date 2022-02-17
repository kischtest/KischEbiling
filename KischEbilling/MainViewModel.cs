using KischEbilling.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using Telerik.Windows.Documents.Spreadsheet;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Formatting.FormatStrings;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Utils;


namespace KischEbilling
{
    partial class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MyCommand = new DelegateCommand(OnCommandExecuted);
        }
        private string pathToSaveExcelFile;

        public ICommand MyCommand { get; set; }
        public ICommand SubmitCommand { get; set; }

        private void OnCommandExecuted(object obj)
        {
            List<InvoiceRecord> invoiceRecords = GetInvoiceRecords();
            DataTable listOfInvoiceNumbersToSearch = GetDataFromExcelAsDt(@"C:\Ebiling\InvoiceListUpload.xlsx");
            ListtoDataTable lsttodt = new ListtoDataTable();
            DataTable invoiceLineItem = lsttodt.ToDataTable(invoiceRecords);
            ExportWorkBookToExcel(invoiceLineItem);
        }

        public DataTable GetDataFromExcelAsDt(string filePath)
        {
            XlsxFormatProvider formatProvider = new XlsxFormatProvider();
            Workbook workbook = formatProvider.Import(File.ReadAllBytes(filePath));

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

            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    //MessageBox.Show(row[col].ToString());
                }
            }

            return table;
        }

        public void ExportWorkBookToExcel(DataTable invoiceLineItem)
        {
            DataTableFormatProvider provider = new DataTableFormatProvider();

            Workbook workbook1 = new Workbook();
            Worksheet invoiceWorkSheet = workbook1.Worksheets.Add();

            provider.Import(invoiceLineItem, invoiceWorkSheet);

            // Step 2: Save Workbook as Excel file
            IWorkbookFormatProvider formatProvider1 = new Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx.XlsxFormatProvider();
            pathToSaveExcelFile = @"C:\Ebiling\GeneratedExcel\EbillingGeneratedExcel" + DateTime.Now.ToString("yyyyMMddHHmmss");

            using (Stream output = new FileStream(pathToSaveExcelFile, FileMode.Create))
            {
                XlsxFormatProvider formatProvider = new XlsxFormatProvider();
                formatProvider.Export(workbook1, output);
                MessageBox.Show("Excel Sheet Generated");
            }
        }

        public List<InvoiceRecord> GetInvoiceRecords()
        {
            List<InvoiceRecord> invoiceRecords = null;
            using (var ctx = new TE_3E_PRODEntities())
            {
                invoiceRecords = ctx.Database.SqlQuery<InvoiceRecord>("SELECT [InvMasterID],[InvDate],[InvNumber] FROM[TE_3E_PROD].[dbo].[InvMaster] where InvNumber = 'I03-0008915'; ", new SqlParameter("@case_id", 277761)).ToList();
            }

            return invoiceRecords;
        }
    }
}
