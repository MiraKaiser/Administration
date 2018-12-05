using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationTool.Models
{
    public class DomainModel
    {
        public int Id { get; set; }
        public ClientModel Client { get; set; }
        public string Name { get; set; }
        public HostingModel Hosting { get; set; }
    }
}