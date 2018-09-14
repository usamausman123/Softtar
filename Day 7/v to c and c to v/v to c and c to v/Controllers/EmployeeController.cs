using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
namespace v_to_c_and_c_to_v.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
 
        [HttpGet]
        public ActionResult Index()
        {
            //ViewBag.Message = Id;
            return View();
        }
        [HttpPost]
        public ActionResult ShowEmployeeData(string name, string id, string salary)  //parameter method
        {
            //for request method 
            /*string Name = Request["name"].ToString();
            int empId = int.Parse(Request["id"].ToString());
            int empSalary = int.Parse(Request["salary"].ToString());*/

            //v to c through parameterized method
            string Name = name.ToString();
            int empId = int.Parse(id.ToString());
            int empSalary = int.Parse(salary.ToString());
           
            StringBuilder sbemp = new StringBuilder();
            sbemp.Append("<b> Employee Name : </b> " + Name + "<br/>");
            sbemp.Append("<b> Employee Id : </b> " + empId + "<br/>");
            sbemp.Append("<b> Employee Salary : </b> " + empSalary + "<br/>");
            //return Content(sbemp.ToString());
            
            //c to v through viewbag method
            ViewBag.nm = "Name is : " + Name;
            ViewBag.Id = "ID is : " + empId;
            ViewBag.sal = "Salary is : " + empSalary;
            return View();
            
        }
	}
}