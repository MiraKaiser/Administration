using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationTool.Models
{
    public class BillItemModel
    { 
        public int Id { get; set; }
        public BillModel BillModel { get; set; }
        public string Description { get; set; }
        public float AmountExBtw { get; set; }
        public DomainModel DomainModel { get; set; }
    }
}