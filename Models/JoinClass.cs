using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_List.Models
{
    public class JoinClass
    {
        public int CategoryID { get; set; }
        public string CategpryName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}