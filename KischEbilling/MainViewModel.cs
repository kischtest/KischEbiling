using LiquidTechnologies.XmlObjects;
using LiquidXmlObjectsCommonV31NoValidation.Wopat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using Telerik.Windows.Controls;
using TPatentsPCT.Models;

namespace TPatentsPCT
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MyCommand = new DelegateCommand(OnCommandExecuted);
            SubmitCommand = new DelegateCommand(OnSubmitCommandExecuted);
        }

        List<CaseData> data;
        List<CaseData> titleText;
        List<CaseData> companyName;
        List<CaseData> filedInEnglish;
        List<Applicant> inventors;
        List<Applicant> applicants;
        List<Priority> priorities;
        List<CaseData> classes;
        List<CaseData> abstractpat;
        List<CaseData> pctNumber;

        public ICommand MyCommand { get; set; }
        public ICommand SubmitCommand { get; set; }
        private ObservableCollection<CaseData> casedata;

        public ObservableCollection<CaseData> CaseData
        {
            get
            {
                if (this.casedata == null)
                {
                    this.casedata = new ObservableCollection<CaseData>();
                }

                return this.casedata;
            }
        }

        private ObservableCollection<Applicant> _applicants;
        public ObservableCollection<Applicant> Applicants
        {
            get
            {
                return this._applicants;

            }
            set
            {
                _applicants = value;
                RaisePropertyChanged("Applicants");
            }
        }

        private ObservableCollection<Applicant> _inventors;
        public ObservableCollection<Applicant> Inventors
        {
            get
            {
                return this._inventors;

            }
            set
            {
                _inventors = value;
                RaisePropertyChanged("Inventors");
            }
        }

        private ObservableCollection<Priority> _priorities;
        public ObservableCollection<Priority> Priorities
        {
            get
            {
                return this._priorities;

            }
            set
            {
                _priorities = value;
                RaisePropertyChanged("Priorities");
            }
        }

        private ObservableCollection<CaseData> _classes;
        public ObservableCollection<CaseData> Classes
        {
            get
            {
                return this._classes;

            }
            set
            {
                _classes = value;
                RaisePropertyChanged("Classes");
            }
        }

        private string _abstractpat;
        public string Abstract
        {
            get { return _abstractpat; }
            set { _abstractpat = value; this.OnPropertyChanged("Abstract"); }
        }

        private string _titleText;
        public string Title
        {
            get { return _titleText; }
            set { _titleText = value; this.OnPropertyChanged("Title"); }
        }

        private string _company;
        public string Company
        {
            get { return _company; }
            set { _company = value; this.OnPropertyChanged("Company"); }
        }

        private string _filedInEnglish;
        public string FiledInEnglish
        {
            get { return _filedInEnglish; }
            set { _filedInEnglish = value; this.OnPropertyChanged("FiledInEnglish"); }
        }

        private string _ourRef;
        public string OurRef
        {
            get { return _ourRef; }
            set { _ourRef = value; this.OnPropertyChanged("OurRef"); }
        }

        private string _patentType;
        public string PatentType
        {
            get { return _patentType; }
            set { _patentType = value; this.OnPropertyChanged("PatentType"); }
        }

        private string _pctNumber;
        public string PctNumber
        {
            get { return _pctNumber; }
            set { _pctNumber = value; this.OnPropertyChanged("PctNumber"); }
        }

        private DateTime _pctDate;
        public DateTime PctDate
        {
            get { return _pctDate; }
            set { _pctDate = value; this.OnPropertyChanged("PctDate"); }
        }
        private void OnCommandExecuted(object obj)
        {
            //MessageBox.Show("MyCommand Executed");
           

            using (var ctx = new PatriciaEntities())
            {
                //var studentList = ctx.ACTOR_LOG
                //                    .SqlQuery("Select * from ACTOR_LOG")
                //                    .ToList<ACTOR_LOG>();
                //context.Database.SqlQuery<Post>("SELECT* FROM dbo.Posts WHERE Author = @author", new SqlParameter("@author", userSuppliedAuthor));
                //test numbers 272276
                data = ctx.Database.SqlQuery<CaseData>("select distinct P.CASE_ID, P.CASE_NUMBER [CASE_NUMBER_SHORT], R.CASE_NUMBER, RTrim(R.CASE_NUMBER) + '/' + left(TM.TEAM_LABEL,2) [FilingReference], (select '; ' + PATENT_CLASS_ID from PATENT_CLASS X where X.CASE_ID = R.CASE_ID ORDER BY SORT_ORDER FOR XML PATH('')) [IPCCLASS], P.CASE_CATCH_WORD, P.STATUS_ID, PS.STATUS_LABEL, P.CASE_ORDER_DATE, A.APPLICATION_TYPE_NAME [PatentType], P.APPLICATION_TYPE_ID, R.APPL_NO from PAT_CASE P inner join PAT_REPORT_TABLE R on P.CASE_ID = R.CASE_ID inner join PAT_STATUS PS on P.STATUS_ID = PS.STATUS_ID inner join WORK_GROUP W on P.CASE_ID = W.CASE_ID inner join TEAM TM on W.TEAM_ID = TM.TEAM_ID inner join APPLICATION_TYPE_TEXT A on P.APPLICATION_TYPE_ID = A.APPLICATION_TYPE_ID where P.CASE_TYPE_ID = 2 and STATE_ID = 'ZA' and A.LANGUAGE_ID = 3 and P.CASE_ID = @case_id order by P.CASE_ID asc; ", new SqlParameter("@case_id", 277761)).ToList();
                inventors = ctx.Database.SqlQuery<Applicant>("SELECT PAT_CASE.CASE_ID AS CASE_ID,PAT_CASE.CASE_NUMBER AS CASE_NO, RTRIM(PAT_NAMES_ENTITY.NAME1) AS PatName1, RTRIM(PAT_NAMES_ENTITY.NAME2) AS PatName2, RTRIM(PAT_NAMES_ADDRESS.ADR1) AS PatAddr1, RTRIM(PAT_NAMES_ADDRESS.ADR2) AS PatAddr2, RTRIM(PAT_NAMES_ADDRESS.ADR3) AS PatAddr3, RTRIM(PAT_NAMES_ADDRESS.Postal_code) AS PatPostalcode, PAT_NAMES_ADDRESS.STATE_ID AS PatCountrycode, RTRIM(STATE_NAME.STATE_NAME) AS PatCountry FROM PAT_CASE, CASTING, PAT_NAMES_ENTITY, PAT_NAMES_ADDRESS, STATE_NAME WHERE (CASTING.CASE_ID=PAT_CASE.CASE_ID) And (CASTING.ROLE_TYPE_ID=3) And (PAT_NAMES_ENTITY.NAME_ID=CASTING.ACTOR_ID) And (PAT_NAMES_ENTITY.CURRENT_ONE=1)  And (PAT_NAMES_ADDRESS.NAME_ID=CASTING.ACTOR_ID) And (PAT_NAMES_ADDRESS.CURRENT_ONE=1)  And (STATE_NAME.STATE_ID=PAT_NAMES_ADDRESS.STATE_ID) And (STATE_NAME.LANGUAGE_ID=3) and PAT_CASE.CASE_ID = @case_id", new SqlParameter("@case_id", 277761)).ToList();
                applicants = ctx.Database.SqlQuery<Applicant>("SELECT PAT_REPORT_TABLE.CASE_NUMBER AS PatCaseNo,PAT_REPORT_TABLE.CASE_ID AS PatCaseId, RTRIM(PAT_NAMES_ENTITY.NAME1) AS PatName1, RTRIM(PAT_NAMES_ENTITY.NAME2) AS PatName2, RTRIM(PAT_NAMES_ADDRESS.ADR1) AS PatAddr1, RTRIM(PAT_NAMES_ADDRESS.ADR2) AS PatAddr2, RTRIM(PAT_NAMES_ADDRESS.ADR3) AS PatAddr3, RTRIM(PAT_NAMES_ADDRESS.Postal_code) AS PatPostalcode, PAT_NAMES_ADDRESS.STATE_ID AS PatCountrycode, RTRIM(STATE_NAME.STATE_NAME) AS PatCountry FROM PAT_REPORT_TABLE, CASTING, PAT_NAMES_ENTITY, PAT_NAMES_ADDRESS, STATE_NAME WHERE (CASTING.CASE_ID=PAT_REPORT_TABLE.CASE_ID) And (CASTING.ROLE_TYPE_ID=2) And (PAT_NAMES_ENTITY.NAME_ID=CASTING.ACTOR_ID) And (PAT_NAMES_ENTITY.CURRENT_ONE=1) And (PAT_NAMES_ADDRESS.NAME_ID=CASTING.ACTOR_ID) And (PAT_NAMES_ADDRESS.CURRENT_ONE=1)  And (STATE_NAME.STATE_ID=PAT_NAMES_ADDRESS.STATE_ID) And (STATE_NAME.LANGUAGE_ID=3) AND PAT_REPORT_TABLE.CASE_ID = @case_id", new SqlParameter("@case_id", 277761)).ToList();
                titleText = ctx.Database.SqlQuery<CaseData>("select TITLE_TEXT from TITLE_TEXT where CASE_ID = @case_id", new SqlParameter("@case_id", 277761)).ToList();
                companyName = ctx.Database.SqlQuery<CaseData>("select DIARY_TEXT from DIARY_TEXT where FIELD_NUMBER = 20150 and CASE_ID = @case_id", new SqlParameter("@case_id", 277761)).ToList();
                filedInEnglish = ctx.Database.SqlQuery<CaseData>("select DIARY_TEXT as FiledInEnglish from PAT_REPORT_TABLE A INNER JOIN DIARY_TEXT B on A.CASE_ID = B.CASE_ID WHERE B.FIELD_NUMBER = 20134 and A.CASE_ID = @case_id", new SqlParameter("@case_id", 277761)).ToList();
                priorities = ctx.Database.SqlQuery<Priority>("select (select DIARY_DATE from DIARY_DATE WHERE FIELD_NUMBER = 5 and CASE_ID = @case_id) as PriorityDate, (select DIARY_TEXT from DIARY_TEXT WHERE FIELD_NUMBER = 6 and CASE_ID = @case_id) as PriorityNo, (select C.STATE_ID from DIARY_TEXT A inner join STATE_NAME C on A.DIARY_TEXT = C.STATE_NAME WHERE LANGUAGE_ID = 3 and FIELD_NUMBER = 7 and CASE_ID = @case_id) as PriorityCountry union select(select DIARY_DATE from DIARY_DATE WHERE FIELD_NUMBER = 112 and CASE_ID = @case_id) as PriorityDate, (select DIARY_TEXT from DIARY_TEXT WHERE FIELD_NUMBER = 114 and CASE_ID = @case_id) as PriorityNo, (select C.STATE_ID from DIARY_TEXT A inner join STATE_NAME C on A.DIARY_TEXT = C.STATE_NAME WHERE LANGUAGE_ID = 3 and FIELD_NUMBER = 119 and CASE_ID = @case_id) as PriorityCountry union select(select DIARY_DATE from DIARY_DATE WHERE FIELD_NUMBER = 120 and CASE_ID = @case_id) as PriorityDate, (select DIARY_TEXT from DIARY_TEXT WHERE FIELD_NUMBER = 123 and CASE_ID = @case_id) as PriorityNo, (select C.STATE_ID from DIARY_TEXT A inner join STATE_NAME C on A.DIARY_TEXT = C.STATE_NAME WHERE LANGUAGE_ID = 3 and FIELD_NUMBER = 142 and CASE_ID = @case_id) as PriorityCountry union select(select DIARY_DATE from DIARY_DATE WHERE FIELD_NUMBER = 144 and CASE_ID = @case_id) as PriorityDate, (select DIARY_TEXT from DIARY_TEXT WHERE FIELD_NUMBER = 85 and CASE_ID = @case_id) as PriorityNo, (select C.STATE_ID from DIARY_TEXT A inner join STATE_NAME C on A.DIARY_TEXT = C.STATE_NAME WHERE LANGUAGE_ID = 3 and FIELD_NUMBER = 145 and CASE_ID = @case_id) as PriorityCountry union select(select DIARY_DATE from DIARY_DATE WHERE FIELD_NUMBER = 17 and CASE_ID = @case_id) as PriorityDate, (select DIARY_TEXT from DIARY_TEXT WHERE FIELD_NUMBER = 56 and CASE_ID = @case_id) as PriorityNo, (select C.STATE_ID from DIARY_TEXT A inner join STATE_NAME C on A.DIARY_TEXT = C.STATE_NAME WHERE LANGUAGE_ID = 3 and FIELD_NUMBER = 76 and CASE_ID = @case_id) as PriorityCountry union select(select DIARY_DATE from DIARY_DATE WHERE FIELD_NUMBER = 61 and CASE_ID = @case_id) as PriorityDate, (select DIARY_TEXT from DIARY_TEXT WHERE FIELD_NUMBER = 115 and CASE_ID = @case_id) as PriorityNo, (select C.STATE_ID from DIARY_TEXT A inner join STATE_NAME C on A.DIARY_TEXT = C.STATE_NAME WHERE LANGUAGE_ID = 3 and FIELD_NUMBER = 122 and CASE_ID = @case_id) as PriorityCountry order by PriorityDate desc", new SqlParameter("@case_id", 277761)).ToList();
                classes = ctx.Database.SqlQuery<CaseData>("SELECT substring(PATENT_CLASS.PATENT_CLASS_ID,1,1) AS Section, substring(PATENT_CLASS.PATENT_CLASS_ID,2,2) AS Class, substring(PATENT_CLASS.PATENT_CLASS_ID,4,1) SubSection FROM PAT_REPORT_TABLE, PATENT_CLASS where  (PATENT_CLASS.CASE_ID=PAT_REPORT_TABLE.CASE_ID) And (PATENT_CLASS.PATENT_CLASS_TYPE=1) and PATENT_CLASS.CASE_ID =  @case_id", new SqlParameter("@case_id", 277761)).ToList();
                abstractpat = ctx.Database.SqlQuery<CaseData>("select ABSTRACT,CASE_PICTURE_PATH from PAT_ABSTRACT A left outer join PAT_CASE_PICTURE B on A.CASE_ID = B.CASE_ID where A.CASE_ID = @case_id", new SqlParameter("@case_id", 277761)).ToList();
                pctNumber = ctx.Database.SqlQuery<CaseData>("select DIARY_TEXT as PctNumber, DIARY_DATE as PCTDate from PAT_REPORT_TABLE A INNER JOIN DIARY_TEXT B ON A.CASE_ID=B.CASE_ID INNER JOIN DIARY_DATE C ON A.CASE_ID=C.CASE_ID WHERE  (B.CASE_ID=A.CASE_ID) And (B.FIELD_NUMBER=93) AND (C.CASE_ID=A.CASE_ID) AND (C.FIELD_NUMBER=3) and A.CASE_ID = @case_id", new SqlParameter("@case_id", 277761)).ToList();

                Applicants = new ObservableCollection<Applicant>(applicants);
                Inventors = new ObservableCollection<Applicant>(inventors);
                Priorities = new ObservableCollection<Priority>(priorities);
                Classes = new ObservableCollection<CaseData>(classes);
                Abstract = abstractpat[0].Abstract;
                Title = titleText[0].Title_Text;
                Company = companyName[0].Diary_Text;
                FiledInEnglish = filedInEnglish[0].FiledInEnglish;
                OurRef = data[0].CASE_NUMBER;
                PatentType = data[0].PatentType;
                PctNumber = pctNumber[0].PctNumber;
                PctDate = pctNumber[0].PctDate;

            }
        }

        private void OnSubmitCommandExecuted(object obj)
        {
            LxReaderSettings lxReaderSettings = new LxReaderSettings();
            lxReaderSettings.ErrorHandler = MyDeserializerErrorHandler;

            var patentTransactionBody = new LxSerializer<PatentTransactionElm>();

           
            //var data = patentTransactionBody.Deserialize(@"C:\Users\DivarR\VirtualBox VMs\XSD-ST96\Test\3\PatentTransaction-NationalPatent.xml");
            //var fileName = Path.Combine(
            //Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
            //    , @"Data\PatentTransaction.xml");
            var data = patentTransactionBody.Deserialize(@"C:\PatentTransaction-NationalPatent.xml");
            //foreach(var node in data.TransactionContentBag.TransactionData.PatentApplication.BibliographicData.ApplicationIdentification.ApplicationNumber)
            //{

            //}
            try
            {
                //foreach (var node in data.PatentTransactionBodies)
                //{
                //    if(node.TransactionContentBag.TransactionData.PatentApplication.BibliographicData.ApplicationIdentification.ApplicationNumber.IPOfficeCode.Value != null)
                //    Console.WriteLine(node.TransactionContentBag.TransactionData.PatentApplication.BibliographicData.ApplicationIdentification.ApplicationNumber.IPOfficeCode.Value);
                //}
            }
            catch(NullReferenceException e)
            {

                Console.WriteLine(e.ToString());
            }

            LxSerializer<PatentTransactionElm> serializer = new LxSerializer<PatentTransactionElm>();
            //using (StringWriter sw = new StringWriter())
            //{
            //    serializer.Serialize(sw, data);

            //    Console.WriteLine(sw.ToString());
            //}

            LxSerializer<PatentTransactionElm> s = new LxSerializer<PatentTransactionElm>();

            using (TextReader textReader = new StreamReader(@"C:\Users\DivarR\VirtualBox VMs\XSD-ST96\Test\3\PatentTransaction-NationalPatent.xml"))
            {
                PatentTransactionElm patentTransactionElm = s.Deserialize(textReader);


                //patentTransactionElm.PatentTransactionBodiesCol.TransactionContentBag.TransactionIdentifier.Value = "batch123-1/20a";

                patentTransactionElm.PatentTransactionBodies[0].TransactionContentBag.TransactionIdentifier.Value = "batch123 - 1 / 20a";

                using (TextWriter textWriter = new StreamWriter(@"C:\Users\DivarR\Documents\Kisch\Tasks\46IPAS\9SourceCode\KischIpas\Kisch.Ipas\PatentTransaction-NationalPatent2.xml"))
                {
                    serializer.Serialize(textWriter, patentTransactionElm);
                }
            }

            Console.ReadLine();
        }

        private void OnCreateANewDocCommandExecuted(object obj)
        {
            var patentTransactionBody = new LxSerializer<PatentTransactionElm>();

        }

        public void MyDeserializerErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, TextLocation location, object targetObject)
        {
            if (severity == LxErrorSeverity.Error)
                Console.WriteLine(msg);
            else if (severity == LxErrorSeverity.Warning)
                Console.WriteLine(msg);
        }
    }
}
