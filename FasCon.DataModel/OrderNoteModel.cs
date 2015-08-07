using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class OrderNoteModel
    {
        public System.Guid OrderNoteId { get; set; }
        public System.Guid OrderId { get; set; }
        public string Note { get; set; }
        public bool DisplayToCustomer { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
    }
}
