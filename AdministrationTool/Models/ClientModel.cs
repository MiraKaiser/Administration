using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationTool.Models
{
    public class ClientModel
    { 
        public int Id { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string BillingName { get; set; }
        public int KvK { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNumber { get; set; }
        public string AddressZip { get; set; }
        public string AddressCity { get; set; }

        public IEnumerable<DomainModel> Domain { get; set; }
        public IEnumerable<BillModel> Bill { get; set; }
    }
}