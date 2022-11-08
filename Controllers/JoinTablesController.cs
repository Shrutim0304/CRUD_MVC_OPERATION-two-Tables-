using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_List;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Product_List.Models;



namespace Product_List.Controllers
{
    public class JoinTablesController : Controller
    {
        // GET: JoinTables
        public ActionResult Index()
        {
            List<JoinClass> jc = new List<JoinClass>();
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery= "Select Category_Details.CategoryID, Category_Details.CategoryName , Product_Details.ProductID, Prdouct_Details.ProductName from Category_Details inner join  On Product_Details Category_Details.C_ID = Product_Details.C_ID";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlconn);
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                JoinClass jcobj = new JoinClass();
                

                jcobj.ProductName = dr["ProductNamae"].ToString();

                

                jcobj.CategpryName = dr["CategoryName"].ToString();
                jc.Add(jcobj);

            }
            return View(jc);
        }
    }
}