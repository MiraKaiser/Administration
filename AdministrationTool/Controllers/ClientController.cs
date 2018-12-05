using AdministrationTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdministrationTool.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ViewResult Edit()
        {
            var client = new ClientModel()
            {
                ContactFirstName = "Monique",
                ContactLastName = "Koopman",
                BillingName = "R-E-D Executive Coaching en \\ Interim Management",
                KvK = 59540532,
                Email = "moniquekoopman@hotmail.nl",
                Phone = 31613202322,
                AddressStreet = "Cura\\c{c}aolaan",
                AddressNumber = "27",
                AddressZip = "1213 VJ",
                AddressCity = "Hilversum",
            };



            return View(client);
        }
    }
}