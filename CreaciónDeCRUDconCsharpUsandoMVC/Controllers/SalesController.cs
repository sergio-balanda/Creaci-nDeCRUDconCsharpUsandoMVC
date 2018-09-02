using CreaciónDeCRUDconCsharpUsandoMVC.Context;
using CreaciónDeCRUDconCsharpUsandoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CreaciónDeCRUDconCsharpUsandoMVC.Controllers
{
    public class SalesController : Controller
    {
        private DataStore db = new DataStore();

        // GET: Sales
        public ActionResult NewOrder()
        {
            OrderView orderview = new OrderView();
            orderview.Customer = new CustomerOrder();
            orderview.Articulos = new List<ArticuloOrder>();
            Session["OrderView"] = orderview;//para no perder datos de una vista a otra
            var list = db.Customers.ToList();
            ViewBag.Id_customer = new SelectList(list, "Id_customer","CompanyName");
            return View(orderview);
        }
        
        public ActionResult AddArticulo()
        {
            var list = db.Articuloes.ToList();
            ViewBag.Id_articulo = new SelectList(list, "Id_articulo", "Product_name");
            return View();
        }
        /*
        [HttpPost]
        public ActionResult AddArticulo()
        {
            var orderiew = Session["Orderview"] as OrderView;
            var Id_product = int.Parse(Request["Id_articulo"]);
            var articulo = db.Articuloes.Find(Id_product);
            ArticuloOrder = new ArticuloOrder()
            {
                Id_articulo=ar
            }
            var list = db.Articuloes.ToList();
            ViewBag.Id_articulo = new SelectList(list, "Id_articulo", "Product_name");
            return View();
        }*/
    }
}