using Dapper;
using Potok.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Potok.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //test
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["PotokConnectionString"].ConnectionString))
            {
                List<Address> address = db.Query<Address>("select * from dbo.AddressCustom").ToList();
            }

            return View();
        }

        public ActionResult Test() {
            return View();
        }
    }
}