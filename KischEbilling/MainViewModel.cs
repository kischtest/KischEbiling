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
   
        public ICommand MyCommand { get; set; }
        public ICommand SubmitCommand { get; set; }
       
        private void OnCommandExecuted(object obj)
        {
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

        private void OnSubmitCommandExecuted(object obj)
        {
            //LxReaderSettings lxReaderSettings = new LxReaderSettings();
            //lxReaderSettings.ErrorHandler = MyDeserializerErrorHandler;

            //var patentTransactionBody = new LxSerializer<PatentTransactionElm>();

           
            ////var data = patentTransactionBody.Deserialize(@"C:\Users\DivarR\VirtualBox VMs\XSD-ST96\Test\3\PatentTransaction-NationalPatent.xml");
            ////var fileName = Path.Combine(
            ////Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
            ////    , @"Data\PatentTransaction.xml");
            //var data = patentTransactionBody.Deserialize(@"C:\PatentTransaction-NationalPatent.xml");
            ////foreach(var node in data.TransactionContentBag.TransactionData.PatentApplication.BibliographicData.ApplicationIdentification.ApplicationNumber)
            ////{

            ////}
            //try
            //{
            //    //foreach (var node in data.PatentTransactionBodies)
            //    //{
            //    //    if(node.TransactionContentBag.TransactionData.PatentApplication.BibliographicData.ApplicationIdentification.ApplicationNumber.IPOfficeCode.Value != null)
            //    //    Console.WriteLine(node.TransactionContentBag.TransactionData.PatentApplication.BibliographicData.ApplicationIdentification.ApplicationNumber.IPOfficeCode.Value);
            //    //}
            //}
            //catch(NullReferenceException e)
            //{

            //    Console.WriteLine(e.ToString());
            //}

            //LxSerializer<PatentTransactionElm> serializer = new LxSerializer<PatentTransactionElm>();
            ////using (StringWriter sw = new StringWriter())
            ////{
            ////    serializer.Serialize(sw, data);

            ////    Console.WriteLine(sw.ToString());
            ////}

            //LxSerializer<PatentTransactionElm> s = new LxSerializer<PatentTransactionElm>();

            //using (TextReader textReader = new StreamReader(@"C:\Users\DivarR\VirtualBox VMs\XSD-ST96\Test\3\PatentTransaction-NationalPatent.xml"))
            //{
            //    PatentTransactionElm patentTransactionElm = s.Deserialize(textReader);


            //    //patentTransactionElm.PatentTransactionBodiesCol.TransactionContentBag.TransactionIdentifier.Value = "batch123-1/20a";

            //    patentTransactionElm.PatentTransactionBodies[0].TransactionContentBag.TransactionIdentifier.Value = "batch123 - 1 / 20a";

            //    using (TextWriter textWriter = new StreamWriter(@"C:\Users\DivarR\Documents\Kisch\Tasks\46IPAS\9SourceCode\KischIpas\Kisch.Ipas\PatentTransaction-NationalPatent2.xml"))
            //    {
            //        serializer.Serialize(textWriter, patentTransactionElm);
            //    }
            //}

            //Console.ReadLine();
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
