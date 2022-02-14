using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace KischEbilling.Models
{
    class InvoiceRecord : ViewModelBase
    {
        public string InvNumber { get; set; }
        public DateTime InvDate { get; set; }
    }
}
