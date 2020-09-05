using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApi.Models
{
    public class Employessclass
    {
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string TotalAmount { get; set; }
        public string ManagerName { get; set; }
    }
}