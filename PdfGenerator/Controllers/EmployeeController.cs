using PdfGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;


namespace PdfGenerator.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmpDBContext db = new EmpDBContext();
        public ActionResult Index()
        {
            var emps = db.Emps.ToList();
            return View(emps);
        }
        public ActionResult PrintAllReport()
        {
            var report = new Rotativa.ActionAsPdf("Index");
            return report;
        }
        public ActionResult IndexById(int id)
        {
            var emp = db.Emps.Where(e => e.ID == id).First();
            return View(emp);
        }
        public ActionResult PrintSalarySlip(int id)
        {
            var report = new ActionAsPdf("IndexById", new { id = id });
            return report;
        }
    }
}