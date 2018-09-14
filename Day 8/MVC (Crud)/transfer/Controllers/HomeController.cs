using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace transfer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string na) //read
        {
            string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\110-Computer\Documents\TRA.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constr);
            string query = "select NAME from Fahad where NAME = '" + na + "';" ;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                /*while (rd.Read())
                {
                    if (rd.GetString(0) == na)
                    {*/
                        rd.Close();
                        con.Close();
                        ViewBag.Message1 = "Record Found";
                        return View();
                  //  }
                //}
            }
            else
            {
                rd.Close();
                con.Close();
                ViewBag.Mes = "record not found";
                return View();
            }
            
            /*if (rd.HasRows)
            {
                ViewBag.read = "Data found";
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                ViewBag.read = "Error in Query";
               // ViewBag.read = rd.ToString();
                return View();
            }*/
            //ViewBag.read = rd.ToString();
            //con.Close();
            //return View();
        }

        public ActionResult About(String na)  //insert
        {
            string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\110-Computer\Documents\TRA.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constr);
            string query = "insert into Fahad (NAME) values('" + na + "') ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                ViewBag.msg = "Data Succussfully Inserted";
                con.Close();
                return View("hello");
            }
            else
            {
                con.Close();
                ViewBag.msg = "Error in Query";
                return View("hello");
            }
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult delete(string na) //delete
        {
            string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\110-Computer\Documents\TRA.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constr);
            string query = "delete from Fahad where NAME = '" + na + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            if (r > 0)
            {
                rd.Close();
                con.Close();
                ViewBag.Message1 = "record deleted successfully!!";
                return View();
                
            }
            else
            {
                rd.Close();
                con.Close();
                ViewBag.Message1 = "record not found";
                return View();
            }
        }

        public ActionResult update (string na1,string na2)
        {
            string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\110-Computer\Documents\TRA.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constr);
            string query = "update Fahad set NAME = '" + na2 + "' where NAME ='" +na1+ "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            if (r>0)
            {
                rd.Close();
                con.Close();
                ViewBag.Message1 = "record updated successfully!!";
                return View();

            }
            else
            {
                rd.Close();
                con.Close();
                ViewBag.Message1 = "record not found";
                return View();
            }
        }
    }
}