using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CreaciónDeCRUDconCsharpUsandoMVC.Context;
using CreaciónDeCRUDconCsharpUsandoMVC.Models;
using System.Net;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Controllers
{
    public class ProductsController : Controller
    {
        private DataStore db = new DataStore();
        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id==null)
            {
                //carga pagina de error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }else { 
                Product product = db.Products.Find(id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                else { 
                    return View(product);
                }
            }
        }
    

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product Products)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Products.Add(Products);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Products);
            }
            catch
            {
                return View(Products);
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                //carga pagina de error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Product product = db.Products.Find(id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(product);
                }
            }
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View(product);
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                //carga pagina de error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Product product = db.Products.Find(id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {/*
            try
            {
                if (ModelState.IsValid) { 
                    product = db.Products.Find(id);
                    if (product == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Products.Remove(product);
                        db.SaveChanges();
                    }
                 return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(product);
            }*/
         //return Json(new { id = id, product = product });
            try
            {
                    product = db.Products.Find(id);
                    if (product == null)
                    {
                        return HttpNotFound();
                    }
                    else { 
                    db.Products.Remove(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                    }
            }
            catch
            {
                return View(product);
            }
           
        }
    }
}
