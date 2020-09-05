using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SalesApi.Models;

namespace SalesApi.Controllers
{
    public class ValuesController : ApiController
    {
       
        DBSalesChartEntities db = new DBSalesChartEntities();   
        // GET api/values
        [Route("api/sales/")]
        public IHttpActionResult Get()
        {
            var result = db.sp_sales().ToList();
            return Ok(result);
        }
        [Route("api/allsales/")]
        [HttpGet]
        public IHttpActionResult allsales()
        {
            var result = db.sp_allsales().ToList();
            return Ok(result);
        }

        [Route("api/manager/")]
        [HttpGet]
        public IHttpActionResult Manager()
        {
            var result = db.sp_manager().ToList();
            return Ok(result);
        }

        [Route("api/newemp")]
        [HttpPost]
        public void post([FromBody]tbl_employee employee)
        {
            using (DBSalesChartEntities db = new DBSalesChartEntities())
            {
                db.tbl_employee.Add(employee);
                db.SaveChanges();
            }


        }

    }
}
