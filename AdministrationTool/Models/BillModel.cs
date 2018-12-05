using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationTool.Models
{
    public class BillModel
    {
        public int Id { get; set; }
        public ClientModel Client { get; set; }
        public float Amount { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime PaidDate { get; set; }
        public String BillContent { get; set; }
        public IEnumerable<BillItemModel> BillItems { get; set; }
    }
}